using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Libs.Migrations
{
    public partial class InitDBv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phims_Phims_PhimId",
                table: "Phims");

            migrationBuilder.DropIndex(
                name: "IX_Phims_PhimId",
                table: "Phims");

            migrationBuilder.DropColumn(
                name: "PhimId",
                table: "Phims");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhimId",
                table: "Phims",
                type: "int",
                nullable: true);

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
        }
    }
}
