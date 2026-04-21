using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBP.DATA;

namespace QLBP.FORM
{
    public partial class frmLichSuHoatDong : Form
    {
        public frmLichSuHoatDong()
        {
            InitializeComponent();
        }

        private void frmLichSuHoatDong_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                using (var context = new QLBPDbContext())
                {
                    var logs = context.Logs
                        .OrderByDescending(l => l.ThoiGian)
                        .Take(500) // Limit to last 500 logs
                        .ToList();
                    dgvLogs.DataSource = logs;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải lịch sử: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá toàn bộ lịch sử hoạt động?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (var context = new QLBPDbContext())
                    {
                        context.Logs.RemoveRange(context.Logs);
                        context.SaveChanges();
                        LoadLogs();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá lịch sử: " + ex.Message);
                }
            }
        }
    }
}
