using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBP.DATA
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public virtual ObservableCollectionListSource<HoaDonChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
