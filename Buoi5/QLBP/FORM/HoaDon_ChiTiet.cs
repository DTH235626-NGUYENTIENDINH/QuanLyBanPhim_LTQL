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
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLBPDbContext context = new QLBPDbContext();
        int id; 
        bool checkViewOnly = false;
        BindingList<DanhSachHoaDonChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>();
        public frmHoaDon_ChiTiet(int maHoaDon = 0, bool viewOnly = false)
        {
            InitializeComponent();
            id = maHoaDon; 
            checkViewOnly = viewOnly;
        }
        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }
        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }
        public void LaySanPhamVaoComboBox()
        {
            cboTenBanPhim.DataSource = context.BanPhim.ToList();
            cboTenBanPhim.ValueMember = "ID";
            cboTenBanPhim.DisplayMember = "TenBP";
        }
        public void batTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0) // Thêm
            {
                // Xóa trắng các trường
                cboNhanVien.Text = "";
                cboKhachHang.Text = "";
                cboTenBanPhim.Text = "";
                numSoLuong.Value = 1;
                numGiaBan.Value = 0;
            }
            btnLuuHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
            if (checkViewOnly)
            {
                // 1. Khóa các nút chức năng
                btnLuuHoaDon.Enabled = false;
                btnXoa.Enabled = false;
                btnXacNhanBan.Enabled = false;

                // 2. Khóa các ô nhập
                cboNhanVien.Enabled = false;
                cboKhachHang.Enabled = false;
                cboTenBanPhim.Enabled = false;
                numSoLuong.Enabled = false;
                numGiaBan.Enabled = false;
                txtGhiChu.ReadOnly = true;

                // Đổi tiêu đề Form
                this.Text = "CHI TIẾT HÓA ĐƠN (CHẾ ĐỘ XEM)";
            }
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayKhachHangVaoComboBox();
            LayNhanVienVaoComboBox();
            LaySanPhamVaoComboBox();
            dataGridView.AutoGenerateColumns = false;
            if (id != 0)
            {
                var hoaDon = context.HoaDon.Where(r => r.ID == id).SingleOrDefault();
                cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                txtGhiChu.Text = hoaDon.GhiChuHoaDon;
                var ct = context.HoaDonChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDonChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    BanPhimID = r.BanPhimID,
                    TenBP = r.BanPhim.TenBP,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();
                hoaDonChiTiet = new BindingList<DanhSachHoaDonChiTiet>(ct);
            }
            dataGridView.DataSource = hoaDonChiTiet;
            batTatChucNang();
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTenBanPhim.Text) ||
                numGiaBan.Value <= 0 || numSoLuong.Value <= 0)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int maSanPham = Convert.ToInt32(cboTenBanPhim.SelectedValue.ToString());
                var spKho = context.BanPhim.Find(maSanPham);
                if (numSoLuong.Value > spKho.SoLuong)
                {
                    MessageBox.Show($"Kho chỉ còn {spKho.SoLuong} cái, không đủ bán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.BanPhimID == maSanPham);
                if (chiTiet != null)
                {
                    chiTiet.SoLuongBan = Convert.ToInt16(numSoLuong.Value);
                    chiTiet.DonGiaBan = Convert.ToInt32(numGiaBan.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuong.Value * numGiaBan.Value);
                    dataGridView.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào
                {
                    // Nếu chưa có sản phẩm nào
                    DanhSachHoaDonChiTiet ct = new DanhSachHoaDonChiTiet
                    {
                        ID = 0,
                        HoaDonID = id,
                        BanPhimID = maSanPham,
                        TenBP = cboTenBanPhim.Text,
                        SoLuongBan = Convert.ToInt16(numSoLuong.Value),
                        DonGiaBan = Convert.ToInt32(numGiaBan.Value),
                        ThanhTien = Convert.ToInt32(numSoLuong.Value * numGiaBan.Value)
                    };
                    hoaDonChiTiet.Add(ct);
                }
                batTatChucNang();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(dataGridView.CurrentRow.Cells["BanPhimID"].Value.ToString());
            var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.BanPhimID == maSanPham);
            if (chiTiet != null)
            {
                hoaDonChiTiet.Remove(chiTiet);
            }
            batTatChucNang();
        }

        private void cboTenBanPhim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maSanPham = Convert.ToInt32(cboTenBanPhim.SelectedValue.ToString());
            var sanPham = context.BanPhim.Find(maSanPham);
            numGiaBan.Value = sanPham.GiaBan;
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null || cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Nhân viên và Khách hàng!", "Lỗi");
                return;
            }

            try
            {
                if (id != 0) // CHẾ ĐỘ CẬP NHẬT
                {
                    HoaDon hd = context.HoaDon.Find(id);
                    if (hd != null)
                    {
                        hd.NhanVienID = (int)cboNhanVien.SelectedValue;
                        hd.KhachHangID = (int)cboKhachHang.SelectedValue;
                        hd.GhiChuHoaDon = txtGhiChu.Text;

                        // 1. Xóa chi tiết cũ và LƯU TRƯỚC một lần để sạch Database
                        var oldDetails = context.HoaDonChiTiet.Where(r => r.HoaDonID == id).ToList();
                        context.HoaDonChiTiet.RemoveRange(oldDetails);
                        context.SaveChanges();

                        // 2. Thêm lại chi tiết mới từ Grid
                        foreach (var item in hoaDonChiTiet)
                        {
                            HoaDonChiTiet ct = new HoaDonChiTiet();
                            ct.HoaDonID = id;
                            ct.BanPhimID = item.BanPhimID;
                            ct.SoLuongBan = (short)item.SoLuongBan; // Ép kiểu cẩn thận
                            ct.DonGiaBan = item.DonGiaBan;
                            context.HoaDonChiTiet.Add(ct);
                        }
                        context.SaveChanges();
                    }
                }
                else // CHẾ ĐỘ THÊM MỚI
                {
                    HoaDon hd = new HoaDon();
                    hd.NhanVienID = (int)cboNhanVien.SelectedValue;
                    hd.KhachHangID = (int)cboKhachHang.SelectedValue;
                    hd.NgayLap = DateTime.Now;
                    hd.GhiChuHoaDon = txtGhiChu.Text;

                    context.HoaDon.Add(hd);
                    context.SaveChanges(); // Lưu để lấy được hd.ID tự tăng

                    foreach (var item in hoaDonChiTiet)
                    {
                        HoaDonChiTiet ct = new HoaDonChiTiet();
                        ct.HoaDonID = hd.ID; // Lấy ID vừa tạo ở trên
                        ct.BanPhimID = item.BanPhimID;
                        ct.SoLuongBan = (short)item.SoLuongBan;
                        ct.DonGiaBan = item.DonGiaBan;
                        context.HoaDonChiTiet.Add(ct);

                        // Giảm số lượng sản phẩm trong kho
                        var sp = context.BanPhim.Find(item.BanPhimID);
                        if (sp != null)
                        {
                            sp.SoLuong -= item.SoLuongBan; // Trừ bớt số lượng trong kho

                            //Kiểm tra xem có bị âm kho không
                            if (sp.SoLuong < 0)
                            {
                                throw new Exception($"Sản phẩm {sp.TenBP} không đủ hàng trong kho!");
                            }
                        }
                    }
                    context.SaveChanges();
                }

                MessageBox.Show("Đã lưu hóa đơn thành công!", "Thông báo");
                this.Close(); // Đóng form sau khi lưu xong

            }
            catch (Exception ex)
            {
                // HIỆN LỖI THẬT SỰ Ở ĐÂY
                string error = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi CSDL: " + error, "Lỗi nghiêm trọng");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
