using QLBP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBP.FORM
{
    public partial class frmLoaiBanPhim : Form
    {
        public frmLoaiBanPhim()
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
        private void LoaiBanPhim_Load(object sender, EventArgs e)
        {
            batTatChucNang(false);

            List<LoaiBanPhim> lbp = new List<LoaiBanPhim>();
            lbp = context.LoaiBanPhims.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lbp;

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

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
            xuLySua   = true;        
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
            if (MessageBox.Show("Xác nhận xoá loại bàn phím này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                LoaiBanPhim lbp = context.LoaiBanPhims.Find(id);
                if(lbp != null)
                {
                    context.LoaiBanPhims.Remove(lbp);
                }
                context.SaveChanges();
                LoaiBanPhim_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    LoaiBanPhim lbp = new LoaiBanPhim();
                    lbp.TenLoai = txtTen.Text;
                    context.LoaiBanPhims.Add(lbp);

                    context.SaveChanges();
                }
                else if(xuLySua)
                {
                    LoaiBanPhim lbp = context.LoaiBanPhims.Find(id);
                    if(lbp !=null)
                    {
                        lbp.TenLoai = txtTen.Text;
                        context.LoaiBanPhims.Update(lbp);

                        context.SaveChanges();
                    }
                }
                else
                {                   
                    string search = txtTen.Text.Trim().ToLower();
                    List<LoaiBanPhim> lbp = context.LoaiBanPhims.Where(x => x.TenLoai.ToLower().Contains(search)).ToList();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = lbp;

                    txtTen.DataBindings.Clear();
                    txtTen.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);
                    dataGridView.DataSource = bindingSource;
                    if (lbp.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;
                    
                }
                LoaiBanPhim_Load(sender, e);
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
            LoaiBanPhim_Load(sender, e);
        }
    }
}
