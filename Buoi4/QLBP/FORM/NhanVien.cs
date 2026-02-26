using QLBP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
namespace QLBP.FORM
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
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
            txtMatKhau.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            List<NhanVien> nv = new List<NhanVien>(); nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            
            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", true, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            xuLySua= false;
            BatTatChucNang(true);

            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();           
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();
            cboQuyenHan.Text = "";
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
            if (MessageBox.Show("Xác nhận xoá người này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((xuLySua || xuLyThem) && (string.IsNullOrWhiteSpace(txtHoVaTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(cboQuyenHan.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtSDT.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 1 ? true : false;
                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                    }
                }
                else if (xuLySua)
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtSDT.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 1 ? true : false;
                        context.NhanVien.Update(nv);
                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false;
                        else
                            nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                        context.SaveChanges();
                    }
                }
                else
                {
                    string ten = txtHoVaTen.Text.Trim().ToLower();
                    string sdt = txtSDT.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim().ToLower();
                    string tenDN = txtTenDangNhap.Text.Trim().ToLower();

                    var query = context.NhanVien.AsQueryable();

                    if (!string.IsNullOrEmpty(ten))
                        query = query.Where(x => x.HoVaTen.ToLower().Contains(ten));

                    if (!string.IsNullOrEmpty(sdt))
                        query = query.Where(x => x.DienThoai.Contains(sdt));

                    if (!string.IsNullOrEmpty(diaChi))
                        query = query.Where(x => x.DiaChi.ToLower().Contains(diaChi));

                    if (!string.IsNullOrEmpty(tenDN))
                        query = query.Where(x => x.TenDangNhap.ToLower().Contains(tenDN));

                    if (cboQuyenHan.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cboQuyenHan.Text))
                    {
                        bool quyen = cboQuyenHan.SelectedIndex == 1 ? true : false;
                        query = query.Where(x => x.QuyenHan == quyen);
                    }

                    List<NhanVien> ketQua = query.ToList();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ketQua;
                    dataGridView.DataSource = bindingSource;

                    txtHoVaTen.DataBindings.Clear();
                    txtDiaChi.DataBindings.Clear();
                    txtSDT.DataBindings.Clear();
                    txtTenDangNhap.DataBindings.Clear();
                    txtMatKhau.DataBindings.Clear();
                    cboQuyenHan.DataBindings.Clear();

                    if (ketQua.Count > 0)
                    {
                        txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
                        txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
                        txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
                        txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);
                        cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", true, DataSourceUpdateMode.Never);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHoVaTen.Clear();
                        txtDiaChi.Clear();
                        txtSDT.Clear();
                        txtTenDangNhap.Clear();
                        txtMatKhau.Clear();
                        cboQuyenHan.Text = "";
                    }
                    return;
                }               
                frmNhanVien_Load(sender, e);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            xuLySua = false;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();
            cboQuyenHan.Text = "";
        }
    }
}
