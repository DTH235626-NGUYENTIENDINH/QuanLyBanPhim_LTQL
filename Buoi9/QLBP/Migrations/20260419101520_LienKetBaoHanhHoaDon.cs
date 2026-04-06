using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLBP.Migrations
{
    /// <inheritdoc />
    public partial class LienKetBaoHanhHoaDon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaoHanh_BanPhim_BanPhimID",
                table: "BaoHanh");

            migrationBuilder.DropForeignKey(
                name: "FK_BaoHanh_KhachHang_KhachHangID",
                table: "BaoHanh");

            migrationBuilder.AddColumn<int>(
                name: "HoaDonChiTietID",
                table: "BaoHanh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BaoHanh_HoaDonChiTietID",
                table: "BaoHanh",
                column: "HoaDonChiTietID");

            migrationBuilder.AddForeignKey(
                name: "FK_BaoHanh_BanPhim_BanPhimID",
                table: "BaoHanh",
                column: "BanPhimID",
                principalTable: "BanPhim",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BaoHanh_HoaDonChiTiet_HoaDonChiTietID",
                table: "BaoHanh",
                column: "HoaDonChiTietID",
                principalTable: "HoaDonChiTiet",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BaoHanh_KhachHang_KhachHangID",
                table: "BaoHanh",
                column: "KhachHangID",
                principalTable: "KhachHang",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaoHanh_BanPhim_BanPhimID",
                table: "BaoHanh");

            migrationBuilder.DropForeignKey(
                name: "FK_BaoHanh_HoaDonChiTiet_HoaDonChiTietID",
                table: "BaoHanh");

            migrationBuilder.DropForeignKey(
                name: "FK_BaoHanh_KhachHang_KhachHangID",
                table: "BaoHanh");

            migrationBuilder.DropIndex(
                name: "IX_BaoHanh_HoaDonChiTietID",
                table: "BaoHanh");

            migrationBuilder.DropColumn(
                name: "HoaDonChiTietID",
                table: "BaoHanh");

            migrationBuilder.AddForeignKey(
                name: "FK_BaoHanh_BanPhim_BanPhimID",
                table: "BaoHanh",
                column: "BanPhimID",
                principalTable: "BanPhim",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaoHanh_KhachHang_KhachHangID",
                table: "BaoHanh",
                column: "KhachHangID",
                principalTable: "KhachHang",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
