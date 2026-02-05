using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLBP.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HangSanXuat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHangSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSanXuat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiBanPhims",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiBanPhims", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuyenHan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BanPhim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HangSanXuatID = table.Column<int>(type: "int", nullable: false),
                    LoaiBanPhimID = table.Column<int>(type: "int", nullable: false),
                    LoaiSwitch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanPhim", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BanPhim_HangSanXuat_HangSanXuatID",
                        column: x => x.HangSanXuatID,
                        principalTable: "HangSanXuat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BanPhim_LoaiBanPhims_LoaiBanPhimID",
                        column: x => x.LoaiBanPhimID,
                        principalTable: "LoaiBanPhims",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    KhachHangID = table.Column<int>(type: "int", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChuHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoaDonID = table.Column<int>(type: "int", nullable: false),
                    SanPhamID = table.Column<int>(type: "int", nullable: false),
                    SoLuongBan = table.Column<short>(type: "smallint", nullable: false),
                    DonGiaBan = table.Column<int>(type: "int", nullable: false),
                    BanPhimID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_BanPhim_BanPhimID",
                        column: x => x.BanPhimID,
                        principalTable: "BanPhim",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_HoaDonID",
                        column: x => x.HoaDonID,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BanPhim_HangSanXuatID",
                table: "BanPhim",
                column: "HangSanXuatID");

            migrationBuilder.CreateIndex(
                name: "IX_BanPhim_LoaiBanPhimID",
                table: "BanPhim",
                column: "LoaiBanPhimID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangID",
                table: "HoaDon",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienID",
                table: "HoaDon",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_BanPhimID",
                table: "HoaDonChiTiet",
                column: "BanPhimID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_HoaDonID",
                table: "HoaDonChiTiet",
                column: "HoaDonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "BanPhim");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "HangSanXuat");

            migrationBuilder.DropTable(
                name: "LoaiBanPhims");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
