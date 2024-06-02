using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libs.Migrations
{
    public partial class InitDBv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhimId",
                table: "VePhims",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhimId",
                table: "Phims",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VePhims_PhimId",
                table: "VePhims",
                column: "PhimId");

            migrationBuilder.CreateIndex(
                name: "IX_Phims_PhimId",
                table: "Phims",
                column: "PhimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phims_Phims_PhimId",
                table: "Phims",
                column: "PhimId",
                principalTable: "Phims",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VePhims_Phims_PhimId",
                table: "VePhims",
                column: "PhimId",
                principalTable: "Phims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phims_Phims_PhimId",
                table: "Phims");

            migrationBuilder.DropForeignKey(
                name: "FK_VePhims_Phims_PhimId",
                table: "VePhims");

            migrationBuilder.DropIndex(
                name: "IX_VePhims_PhimId",
                table: "VePhims");

            migrationBuilder.DropIndex(
                name: "IX_Phims_PhimId",
                table: "Phims");

            migrationBuilder.DropColumn(
                name: "PhimId",
                table: "VePhims");

            migrationBuilder.DropColumn(
                name: "PhimId",
                table: "Phims");
        }
    }
}
