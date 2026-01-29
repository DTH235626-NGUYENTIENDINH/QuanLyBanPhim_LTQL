using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBP.DATA
{
    public class QLBPDbContext : DbContext
    {
        public DbSet<LoaiBanPhim> LoaiBanPhims { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<BanPhim> banPhim { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBPConnection"].ConnectionString);
        }
    }
}

