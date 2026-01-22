using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBP.DATA
{
    public class BanPhim
    {
        public int ID { get; set; }
        public string TenBP { get; set; }
        public string HangSanXuatID { get; set; }
        public string LoaiBanPhimID { get; set; }
        public string LoaiSwitch { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

        public virtual ObservableCollectionListSource<HoaDonChiTiet> HoaDonChiTiet { get; } = new();
        public virtual LoaiBanPhim LoaiBanPhim { get; set; } = null!;
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;
    }

}

