using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLBP.Migrations
{
    /// <inheritdoc />
    public partial class ThemBaoHanhVaPhanQuyen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuyenHan",
                table: "NhanVien");

            migrationBuilder.AddColumn<int>(
                name: "VaiTro",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BaoHanh",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BanPhimID = table.Column<int>(type: "int", nullable: false),
                    KhachHangID = table.Column<int>(type: "int", nullable: false),
                    NhanVienID = table.Column<int>(type: "int", nullable: true),
                    NgayTiepNhan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTraKhach = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MoTaLoi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDungSuaChua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiPhiSuaChua = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoHanh", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BaoHanh_BanPhim_BanPhimID",
                        column: x => x.BanPhimID,
                        principalTable: "BanPhim",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaoHanh_KhachHang_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaoHanh_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaoHanh_BanPhimID",
                table: "BaoHanh",
                column: "BanPhimID");

            migrationBuilder.CreateIndex(
                name: "IX_BaoHanh_KhachHangID",
                table: "BaoHanh",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_BaoHanh_NhanVienID",
                table: "BaoHanh",
                column: "NhanVienID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoHanh");

            migrationBuilder.DropColumn(
                name: "VaiTro",
                table: "NhanVien");

            migrationBuilder.AddColumn<bool>(
                name: "QuyenHan",
                table: "NhanVien",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
