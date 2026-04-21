using QLBP.DATA;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmBaoHanh : Form
    {
        int? prefilledHoaDonID = null;
        private NhanVien currentUser;

        public frmBaoHanh(int? maHoaDon = null, NhanVien user = null)
        {
            InitializeComponent();
            prefilledHoaDonID = maHoaDon;
            currentUser = user;
        }

        QLBPDbContext context = new QLBPDbContext();
        bool xuLyThem = false;
        bool xuLySua = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            // Phân quyền chi tiết trên các trường
            bool isSales = (currentUser != null && currentUser.VaiTro == 1);
            bool isWarranty = (currentUser != null && currentUser.VaiTro == 2);
            bool isAdmin = (currentUser == null || currentUser.VaiTro == 0);

            // Nhân viên bán hàng chỉ được nhập thông tin ban đầu
            txtMoTaLoi.Enabled = giaTri && (isSales || isWarranty || isAdmin);
            txtGhiChu.Enabled = giaTri && (isSales || isWarranty || isAdmin);
            
            // Nhân viên bảo hành/Admin mới được nhập nội dung sửa và chi phí
            txtNoiDung.Enabled = giaTri && (isWarranty || isAdmin);
            txtChiPhi.Enabled = giaTri && (isWarranty || isAdmin);
            cboTrangThai.IsReadOnly = !giaTri || isSales;
            dtpNgayTra.Enabled = giaTri && (isWarranty || isAdmin);
            chkDaTra.Enabled = giaTri && (isWarranty || isAdmin);
            chkDaTra.ForeColor = (giaTri && (isWarranty || isAdmin)) ? Color.White : Color.White;

            cboKhachHang.IsReadOnly = !giaTri || (isWarranty && !xuLyThem); // Bảo hành không đổi khách khi đang sửa
            cboHoaDon.IsReadOnly = !giaTri || (isWarranty && !xuLyThem);
            cboBanPhim.IsReadOnly = !giaTri || (isWarranty && !xuLyThem);
            cboNhanVien.IsReadOnly = !giaTri || isSales;

            dtpNgayTiepNhan.Enabled = giaTri && (isSales || isAdmin);

            btnThem.Enabled = !giaTri && (isSales || isAdmin); // Ưu tiên Sales/Admin tạo mới
            btnSua.Enabled = !giaTri && (isWarranty || isAdmin); // Ưu tiên Warranty/Admin sửa chữa
            btnXoa.Enabled = !giaTri && isAdmin;
            btnTimKiem.Enabled = !giaTri;
        }

        private string TrangThaiToString(int trangThai)
        {
            return trangThai switch
            {
                0 => "Tiếp nhận",
                1 => "Đang sửa chữa",
                2 => "Hoàn thành",
                3 => "Đã trả khách",
                _ => "Không xác định"
            };
        }

        private void LoadData()
        {
            context = new QLBPDbContext();
            var list = context.BaoHanh
                .Include(b => b.BanPhim)
                .Include(b => b.KhachHang)
                .Include(b => b.NhanVien)
                .Include(b => b.HoaDonChiTiet).ThenInclude(ct => ct.HoaDon)
                .AsEnumerable()
                .Select(b => new DanhSachBaoHanh
                {
                    ID = b.ID,
                    BanPhimID = b.BanPhimID,
                    TenBanPhim = b.BanPhim.TenBP,
                    KhachHangID = b.KhachHangID,
                    TenKhachHang = b.KhachHang.HoVaTen,
                    HoaDonID = b.HoaDonChiTiet != null ? b.HoaDonChiTiet.HoaDonID : 0,
                    HoaDonChiTietID = b.HoaDonChiTietID,
                    NhanVienID = b.NhanVienID,
                    TenNhanVien = b.NhanVien != null ? b.NhanVien.HoVaTen : "",
                    NgayTiepNhan = b.NgayTiepNhan,
                    NgayTraKhach = b.NgayTraKhach,
                    MoTaLoi = b.MoTaLoi,
                    NoiDungSuaChua = b.NoiDungSuaChua,
                    ChiPhiSuaChua = b.ChiPhiSuaChua,
                    TrangThai = TrangThaiToString(b.TrangThai),
                    NgayHetHanBH = b.HoaDonChiTiet.HoaDon.NgayLap.AddMonths(b.HoaDonChiTiet.ThoiGianBaoHanh),
                    GhiChu = b.GhiChu
                }).ToList();

            dataGridView.DataSource = list;

            if (dataGridView.Columns.Count > 0)
            {
                // Ẩn các cột ID thừa
                dataGridView.Columns["BanPhimID"].Visible = false;
                dataGridView.Columns["KhachHangID"].Visible = false;
                dataGridView.Columns["HoaDonChiTietID"].Visible = false;
                dataGridView.Columns["NhanVienID"].Visible = false;

                // Tuỳ chỉnh tên cột
                dataGridView.Columns["ID"].HeaderText = "Mã BH";
                dataGridView.Columns["ID"].FillWeight = 50;
                dataGridView.Columns["TenBanPhim"].HeaderText = "Sản phẩm";
                dataGridView.Columns["TenKhachHang"].HeaderText = "Khách hàng";
                dataGridView.Columns["HoaDonID"].HeaderText = "HĐ";
                dataGridView.Columns["HoaDonID"].FillWeight = 50;
                dataGridView.Columns["TenNhanVien"].HeaderText = "Nhân viên";
                dataGridView.Columns["NgayTiepNhan"].HeaderText = "Ngày nhận";
                dataGridView.Columns["NgayTraKhach"].HeaderText = "Ngày trả";
                dataGridView.Columns["MoTaLoi"].HeaderText = "Mô tả lỗi";
                dataGridView.Columns["NoiDungSuaChua"].HeaderText = "Nội dung sửa";
                dataGridView.Columns["ChiPhiSuaChua"].HeaderText = "Chi phí";
                dataGridView.Columns["TrangThai"].HeaderText = "Trạng thái";
                dataGridView.Columns["NgayHetHanBH"].HeaderText = "Hết hạn BH";
                dataGridView.Columns["GhiChu"].HeaderText = "Ghi chú";
            }
        }

        private void LoadComboBoxes()
        {
            // Khách hàng
            var khachHangs = context.KhachHang.Select(k => new { k.ID, k.HoVaTen }).ToList();
            cboKhachHang.DataSource = khachHangs;
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.ValueMember = "ID";

            // Nhân viên
            var nhanViens = context.NhanVien
                .Where(n => n.VaiTro == 0 || n.VaiTro == 2)
                .Select(n => new { n.ID, n.HoVaTen }).ToList();
            cboNhanVien.DataSource = nhanViens;
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";
            
            if (currentUser != null && (currentUser.VaiTro == 0 || currentUser.VaiTro == 2))
            {
                cboNhanVien.SelectedValue = currentUser.ID;
            }

            cboKhachHang.SelectedIndex = -1;
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue != null && int.TryParse(cboKhachHang.SelectedValue.ToString(), out int khId))
            {
                var hoaDons = context.HoaDon.Where(h => h.KhachHangID == khId).Select(h => new { h.ID, Display = "HĐ " + h.ID + " - " + h.NgayLap.ToString("dd/MM/yyyy") }).ToList();
                cboHoaDon.DataSource = hoaDons;
                cboHoaDon.DisplayMember = "Display";
                cboHoaDon.ValueMember = "ID";
                cboHoaDon.SelectedIndex = -1;
                cboBanPhim.DataSource = null;
            }
        }

        private void cboHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHoaDon.SelectedValue != null && int.TryParse(cboHoaDon.SelectedValue.ToString(), out int hdId))
            {
                var sanPhams = context.HoaDonChiTiet.Where(ct => ct.HoaDonID == hdId).Select(ct => new { ct.ID, Display = ct.BanPhim.TenBP }).ToList();
                cboBanPhim.DataSource = sanPhams;
                cboBanPhim.DisplayMember = "Display";
                cboBanPhim.ValueMember = "ID"; // Lưu HoaDonChiTietID
                cboBanPhim.SelectedIndex = -1;
            }
        }
        
        private void cboBanPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBanPhim.SelectedValue != null && int.TryParse(cboBanPhim.SelectedValue.ToString(), out int hdctId))
            {
                var hdct = context.HoaDonChiTiet.Include(ct => ct.HoaDon).FirstOrDefault(ct => ct.ID == hdctId);
                if (hdct != null)
                {
                    DateTime ngayLap = hdct.HoaDon.NgayLap;
                    int thangBH = hdct.ThoiGianBaoHanh;
                    DateTime ngayHetHan = ngayLap.AddMonths(thangBH);

                    if (DateTime.Now <= ngayHetHan)
                    {
                        lblBaoHanhStatus.Text = $"(CÒN BẢO HÀNH) - Hết hạn: {ngayHetHan:dd/MM/yyyy}";
                        lblBaoHanhStatus.ForeColor = Color.SpringGreen;
                    }
                    else
                    {
                        lblBaoHanhStatus.Text = $"(HẾT BẢO HÀNH) - Hết hạn: {ngayHetHan:dd/MM/yyyy}";
                        lblBaoHanhStatus.ForeColor = Color.OrangeRed;
                    }
                }
            }
            else
            {
                lblBaoHanhStatus.Text = "Tình trạng bảo hành: --";
                lblBaoHanhStatus.ForeColor = Color.Yellow;
            }
        }

        private void frmBaoHanh_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = true;
            LoadComboBoxes();
            LoadData();

            if (prefilledHoaDonID.HasValue)
            {
                btnThem_Click(null, null);
                var hd = context.HoaDon.Find(prefilledHoaDonID.Value);
                if (hd != null)
                {
                    cboKhachHang.SelectedValue = hd.KhachHangID;
                    cboKhachHang_SelectedIndexChanged(null, null);
                    cboHoaDon.SelectedValue = hd.ID;
                    cboHoaDon_SelectedIndexChanged(null, null);
                }
            }
        }

        private void ClearForm()
        {
            txtMoTaLoi.Clear();
            txtNoiDung.Clear();
            txtChiPhi.Clear();
            txtGhiChu.Clear();
            cboTrangThai.SelectedIndex = 0;
            dtpNgayTiepNhan.Value = DateTime.Now;
            chkDaTra.Checked = false;
            lblBaoHanhStatus.Text = "Tình trạng bảo hành: --";
            lblBaoHanhStatus.ForeColor = Color.Yellow;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            xuLySua = false;
            BatTatChucNang(true);
            ClearForm();
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
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
            LoadFromGrid();
        }

        private void LoadFromGrid()
        {
            var row = dataGridView.CurrentRow;
            if (row == null) return;

            var bh = context.BaoHanh.Include(b => b.HoaDonChiTiet).FirstOrDefault(b => b.ID == Convert.ToInt32(row.Cells["ID"].Value));
            if (bh == null) return;

            cboKhachHang.SelectedValue = bh.KhachHangID;
            cboKhachHang_SelectedIndexChanged(null, null);
            
            if (bh.HoaDonChiTiet != null)
            {
                cboHoaDon.SelectedValue = bh.HoaDonChiTiet.HoaDonID;
                cboHoaDon_SelectedIndexChanged(null, null);
                cboBanPhim.SelectedValue = bh.HoaDonChiTietID;
            }
            if (bh.NhanVienID.HasValue) cboNhanVien.SelectedValue = bh.NhanVienID.Value;
            txtMoTaLoi.Text = bh.MoTaLoi;
            txtNoiDung.Text = bh.NoiDungSuaChua ?? "";
            txtChiPhi.Text = bh.ChiPhiSuaChua.ToString();
            txtGhiChu.Text = bh.GhiChu ?? "";
            cboTrangThai.SelectedIndex = bh.TrangThai;
            dtpNgayTiepNhan.Value = bh.NgayTiepNhan;
            if (bh.NgayTraKhach.HasValue)
            {
                chkDaTra.Checked = true;
                dtpNgayTra.Value = bh.NgayTraKhach.Value;
            }
            else
            {
                chkDaTra.Checked = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xác nhận xoá phiếu bảo hành này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                var bh = context.BaoHanh.Find(id);
                if (bh != null)
                {
                    context.BaoHanh.Remove(bh);
                    context.SaveChanges();
                }
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMoTaLoi.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboBanPhim.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần bảo hành!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                BaoHanh bh = new BaoHanh();
                bh.HoaDonChiTietID = Convert.ToInt32(cboBanPhim.SelectedValue);
                var hdct = context.HoaDonChiTiet.Find(bh.HoaDonChiTietID);
                bh.BanPhimID = hdct != null ? hdct.BanPhimID : 0;
                bh.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                bh.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                bh.NgayTiepNhan = dtpNgayTiepNhan.Value;
                bh.NgayTraKhach = chkDaTra.Checked ? dtpNgayTra.Value : null;
                bh.MoTaLoi = txtMoTaLoi.Text;
                bh.NoiDungSuaChua = txtNoiDung.Text;
                int.TryParse(txtChiPhi.Text, out int cp);
                bh.ChiPhiSuaChua = cp;
                bh.TrangThai = cboTrangThai.SelectedIndex;
                bh.GhiChu = txtGhiChu.Text;
                context.BaoHanh.Add(bh);
                context.SaveChanges();
            }
            else if (xuLySua)
            {
                var bh = context.BaoHanh.Find(id);
                if (bh != null)
                {
                    bh.HoaDonChiTietID = Convert.ToInt32(cboBanPhim.SelectedValue);
                    var hdct = context.HoaDonChiTiet.Find(bh.HoaDonChiTietID);
                    bh.BanPhimID = hdct != null ? hdct.BanPhimID : 0;
                    bh.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                    bh.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue);
                    bh.NgayTiepNhan = dtpNgayTiepNhan.Value;
                    bh.NgayTraKhach = chkDaTra.Checked ? dtpNgayTra.Value : null;
                    bh.MoTaLoi = txtMoTaLoi.Text;
                    bh.NoiDungSuaChua = txtNoiDung.Text;
                    int.TryParse(txtChiPhi.Text, out int cp);
                    bh.ChiPhiSuaChua = cp;
                    bh.TrangThai = cboTrangThai.SelectedIndex;
                    bh.GhiChu = txtGhiChu.Text;
                    context.SaveChanges();
                }
            }
            LoadData();
            BatTatChucNang(false);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtMoTaLoi.Text.Trim().ToLower();
            context = new QLBPDbContext();
            var query = context.BaoHanh
                .Include(b => b.BanPhim)
                .Include(b => b.KhachHang)
                .Include(b => b.NhanVien)
                .Include(b => b.HoaDonChiTiet).ThenInclude(ct => ct.HoaDon)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(b =>
                    b.MoTaLoi.ToLower().Contains(keyword) ||
                    b.KhachHang.HoVaTen.ToLower().Contains(keyword) ||
                    b.BanPhim.TenBP.ToLower().Contains(keyword));
            }

            var list = query.AsEnumerable().Select(b => new DanhSachBaoHanh
            {
                ID = b.ID,
                BanPhimID = b.BanPhimID,
                TenBanPhim = b.BanPhim.TenBP,
                KhachHangID = b.KhachHangID,
                TenKhachHang = b.KhachHang.HoVaTen,
                HoaDonID = b.HoaDonChiTiet != null ? b.HoaDonChiTiet.HoaDonID : 0,
                HoaDonChiTietID = b.HoaDonChiTietID,
                NhanVienID = b.NhanVienID,
                TenNhanVien = b.NhanVien != null ? b.NhanVien.HoVaTen : "",
                NgayTiepNhan = b.NgayTiepNhan,
                NgayTraKhach = b.NgayTraKhach,
                MoTaLoi = b.MoTaLoi,
                NoiDungSuaChua = b.NoiDungSuaChua,
                ChiPhiSuaChua = b.ChiPhiSuaChua,
                TrangThai = TrangThaiToString(b.TrangThai),
                NgayHetHanBH = b.HoaDonChiTiet.HoaDon.NgayLap.AddMonths(b.HoaDonChiTiet.ThoiGianBaoHanh),
                GhiChu = b.GhiChu
            }).ToList();

            dataGridView.DataSource = list;

            if (list.Count == 0)
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (!xuLyThem && !xuLySua && dataGridView.CurrentRow != null)
            {
                LoadFromGrid();
            }
        }
    }
}
