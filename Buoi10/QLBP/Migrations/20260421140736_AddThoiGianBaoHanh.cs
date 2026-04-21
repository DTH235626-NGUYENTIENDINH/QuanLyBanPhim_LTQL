using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLBP.Migrations
{
    /// <inheritdoc />
    public partial class AddThoiGianBaoHanh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThoiGianBaoHanh",
                table: "HoaDonChiTiet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ThoiGianBaoHanh",
                table: "BanPhim",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThoiGianBaoHanh",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "ThoiGianBaoHanh",
                table: "BanPhim");
        }
    }
}
