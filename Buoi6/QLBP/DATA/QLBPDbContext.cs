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
        public DbSet<BanPhim> BanPhim { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public DbSet<BaoHanh> BaoHanh { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBPConnection"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BaoHanh>()
                .HasOne(b => b.HoaDonChiTiet)
                .WithMany(h => h.BaoHanh)
                .HasForeignKey(b => b.HoaDonChiTietID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BaoHanh>()
                .HasOne(b => b.BanPhim)
                .WithMany(bp => bp.BaoHanh)
                .HasForeignKey(b => b.BanPhimID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<BaoHanh>()
                .HasOne(b => b.KhachHang)
                .WithMany(kh => kh.BaoHanh)
                .HasForeignKey(b => b.KhachHangID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
