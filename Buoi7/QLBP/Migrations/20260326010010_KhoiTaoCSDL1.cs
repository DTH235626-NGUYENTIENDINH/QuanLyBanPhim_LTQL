using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLBP.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_banPhim_HangSanXuat_HangSanXuatID",
                table: "banPhim");

            migrationBuilder.DropForeignKey(
                name: "FK_banPhim_LoaiBanPhims_LoaiBanPhimID",
                table: "banPhim");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_banPhim_BanPhimID",
                table: "HoaDonChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_banPhim",
                table: "banPhim");

            migrationBuilder.DropColumn(
                name: "SanPhamID",
                table: "HoaDonChiTiet");

            migrationBuilder.RenameTable(
                name: "banPhim",
                newName: "BanPhim");

            migrationBuilder.RenameIndex(
                name: "IX_banPhim_LoaiBanPhimID",
                table: "BanPhim",
                newName: "IX_BanPhim_LoaiBanPhimID");

            migrationBuilder.RenameIndex(
                name: "IX_banPhim_HangSanXuatID",
                table: "BanPhim",
                newName: "IX_BanPhim_HangSanXuatID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BanPhim",
                table: "BanPhim",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BanPhim_HangSanXuat_HangSanXuatID",
                table: "BanPhim",
                column: "HangSanXuatID",
                principalTable: "HangSanXuat",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BanPhim_LoaiBanPhims_LoaiBanPhimID",
                table: "BanPhim",
                column: "LoaiBanPhimID",
                principalTable: "LoaiBanPhims",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_BanPhim_BanPhimID",
                table: "HoaDonChiTiet",
                column: "BanPhimID",
                principalTable: "BanPhim",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BanPhim_HangSanXuat_HangSanXuatID",
                table: "BanPhim");

            migrationBuilder.DropForeignKey(
                name: "FK_BanPhim_LoaiBanPhims_LoaiBanPhimID",
                table: "BanPhim");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonChiTiet_BanPhim_BanPhimID",
                table: "HoaDonChiTiet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BanPhim",
                table: "BanPhim");

            migrationBuilder.RenameTable(
                name: "BanPhim",
                newName: "banPhim");

            migrationBuilder.RenameIndex(
                name: "IX_BanPhim_LoaiBanPhimID",
                table: "banPhim",
                newName: "IX_banPhim_LoaiBanPhimID");

            migrationBuilder.RenameIndex(
                name: "IX_BanPhim_HangSanXuatID",
                table: "banPhim",
                newName: "IX_banPhim_HangSanXuatID");

            migrationBuilder.AddColumn<int>(
                name: "SanPhamID",
                table: "HoaDonChiTiet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_banPhim",
                table: "banPhim",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_banPhim_HangSanXuat_HangSanXuatID",
                table: "banPhim",
                column: "HangSanXuatID",
                principalTable: "HangSanXuat",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_banPhim_LoaiBanPhims_LoaiBanPhimID",
                table: "banPhim",
                column: "LoaiBanPhimID",
                principalTable: "LoaiBanPhims",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonChiTiet_banPhim_BanPhimID",
                table: "HoaDonChiTiet",
                column: "BanPhimID",
                principalTable: "banPhim",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
