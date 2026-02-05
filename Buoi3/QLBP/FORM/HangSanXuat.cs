using QLBP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBP.FORM
{
    public partial class frmHangSanXuat : Form
    {
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        QLBPDbContext context = new QLBPDbContext();
        bool xuLyThem = false;
        bool xuLySua = false;
        int id;
        private void batTatChucNang(bool gt)
        {
            btnLuu.Enabled = gt;
            btnHuyBo.Enabled = gt;
            txtTen.Enabled = gt;

            btnThem.Enabled = !gt;
            btnSua.Enabled = !gt;
            btnXoa.Enabled = !gt;
            btnTimKiem.Enabled = !gt;
        }
        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            batTatChucNang(false);
            List<HangSanXuat> hsx = new List<HangSanXuat>();
            hsx = context.HangSanXuat.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = hsx;

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            xuLySua = false;
            batTatChucNang(true);
            txtTen.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            xuLyThem = false;
            xuLySua = true;
            batTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xác nhận xoá hãng này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HangSanXuat hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    context.HangSanXuat.Remove(hsx);
                }
                context.SaveChanges();
                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                if (xuLyThem)
                {
                    HangSanXuat hsx = new HangSanXuat();
                    hsx.TenHangSanXuat = txtTen.Text;
                    context.HangSanXuat.Add(hsx);
                    context.SaveChanges();
                } 
                else if (xuLySua)
                {
                    HangSanXuat hsx = context.HangSanXuat.Find(id);
                    if (hsx != null)
                    {
                        hsx.TenHangSanXuat = txtTen.Text;
                        context.HangSanXuat.Update(hsx);
                        context.SaveChanges();
                    }
                }
                else
                {
                    string search = txtTen.Text.Trim().ToLower();
                    List<HangSanXuat> hsx = context.HangSanXuat.Where(x => x.TenHangSanXuat.ToLower().Contains(search)).ToList();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = hsx;
                    txtTen.DataBindings.Clear();
                    txtTen.DataBindings.Add("Text", bindingSource, "TenHangSanXuat", false, DataSourceUpdateMode.Never);
                    dataGridView.DataSource = bindingSource;
                    if (hsx.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;                
                }
                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            xuLySua = false;
            xuLyThem = false;
            batTatChucNang(true);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }

        
    }
}
