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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        QLBPDbContext context = new QLBPDbContext();
        bool xuLyThem = false;
        bool xuLySua = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtHoVaTen.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            xuLySua = false;
            BatTatChucNang(true);

            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
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
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Xác nhận xóa khách hàng này?" + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((xuLyThem || xuLySua)&&(string.IsNullOrWhiteSpace(txtHoVaTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.DienThoai = txtSDT.Text;
                    context.KhachHang.Add(kh);
                    
                    context.SaveChanges();
                }
                else if (xuLySua)
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if(kh != null)
                    {
                        kh.HoVaTen = txtHoVaTen.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        kh.DienThoai = txtSDT.Text;
                        context.KhachHang.Update(kh);

                        context.SaveChanges() ;
                    }

                }
                else
                {
                    string tenCanTim = txtHoVaTen.Text.Trim().ToLower();
                    string sdtCanTim = txtSDT.Text.Trim();
                    string diaChiCanTim = txtDiaChi.Text.Trim().ToLower();
                    var query = context.KhachHang.AsQueryable();
                    //Lọc theo Tên
                    if (!string.IsNullOrEmpty(tenCanTim))
                    {
                        query = query.Where(k => k.HoVaTen.ToLower().Contains(tenCanTim));
                    }

                    //Lọc theo SĐT
                    if (!string.IsNullOrEmpty(sdtCanTim))
                    {
                        query = query.Where(k => k.DienThoai.Contains(sdtCanTim));
                    }

                    //Lọc theo Địa chỉ
                    if (!string.IsNullOrEmpty(diaChiCanTim))
                    {
                        query = query.Where(k => k.DiaChi.ToLower().Contains(diaChiCanTim));
                    }

                    List<KhachHang> ketQuaTimKiem = query.ToList();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ketQuaTimKiem;
                    dataGridView.DataSource = bindingSource;


                    txtHoVaTen.DataBindings.Clear();
                    txtDiaChi.DataBindings.Clear();
                    txtSDT.DataBindings.Clear();

                    if (ketQuaTimKiem.Count > 0)
                    {
                        txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
                        txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
                        txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHoVaTen.Clear();
                        txtDiaChi.Clear();
                        txtSDT.Clear();
                    }
                    return;
                }
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            xuLySua = false;
            xuLyThem = false;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }
    }
}

