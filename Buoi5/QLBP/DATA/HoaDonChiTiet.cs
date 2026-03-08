using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBP.DATA
{
    public class HoaDonChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int BanPhimID { get; set; }
        public short SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual BanPhim BanPhim { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachHoaDonChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int BanPhimID { get; set; }
        public string TenBP { get; set; }
        public short SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public int ThanhTien { get; set; }
    }
}
