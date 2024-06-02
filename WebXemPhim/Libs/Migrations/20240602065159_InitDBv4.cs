using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libs.Migrations
{
    public partial class InitDBv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VePhims_HoaDonDichVus_HoaDonDichVuId",
                table: "VePhims");

            migrationBuilder.DropIndex(
                name: "IX_VePhims_HoaDonDichVuId",
                table: "VePhims");

            migrationBuilder.DropColumn(
                name: "HoaDonDichVuId",
                table: "VePhims");

            migrationBuilder.AddColumn<int>(
                name: "VePhimId",
                table: "HoaDonDichVus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonDichVus_VePhimId",
                table: "HoaDonDichVus",
                column: "VePhimId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonDichVus_VePhims_VePhimId",
                table: "HoaDonDichVus",
                column: "VePhimId",
                principalTable: "VePhims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonDichVus_VePhims_VePhimId",
                table: "HoaDonDichVus");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonDichVus_VePhimId",
                table: "HoaDonDichVus");

            migrationBuilder.DropColumn(
                name: "VePhimId",
                table: "HoaDonDichVus");

            migrationBuilder.AddColumn<int>(
                name: "HoaDonDichVuId",
                table: "VePhims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VePhims_HoaDonDichVuId",
                table: "VePhims",
                column: "HoaDonDichVuId");

            migrationBuilder.AddForeignKey(
                name: "FK_VePhims_HoaDonDichVus_HoaDonDichVuId",
                table: "VePhims",
                column: "HoaDonDichVuId",
                principalTable: "HoaDonDichVus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
