using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBP.DATA
{
    public class BaoHanh
    {
        public int ID { get; set; }
        public int BanPhimID { get; set; }
        public int KhachHangID { get; set; }
        public int? NhanVienID { get; set; }
        public int HoaDonChiTietID { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public DateTime? NgayTraKhach { get; set; }
        public string MoTaLoi { get; set; }
        public string? NoiDungSuaChua { get; set; }
        public int ChiPhiSuaChua { get; set; }
        // 0 = Tiếp nhận, 1 = Đang sửa chữa, 2 = Hoàn thành, 3 = Đã trả khách
        public int TrangThai { get; set; }
        public string? GhiChu { get; set; }

        public virtual BanPhim BanPhim { get; set; } = null!;
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien? NhanVien { get; set; }
        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachBaoHanh
    {
        public int ID { get; set; }
        public int BanPhimID { get; set; }
        public string TenBanPhim { get; set; }
        public int KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public int HoaDonID { get; set; }
        public int HoaDonChiTietID { get; set; }
        public int? NhanVienID { get; set; }
        public string? TenNhanVien { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public DateTime? NgayTraKhach { get; set; }
        public string MoTaLoi { get; set; }
        public string? NoiDungSuaChua { get; set; }
        public int ChiPhiSuaChua { get; set; }
        public string TrangThai { get; set; }
        public string? GhiChu { get; set; }
    }
}
