using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramlamaOdev.DataAccessLayer.Migrations
{
    public partial class mig_hasta_duzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Hasta_HastaId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_HastaId",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "HastaId",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "HastaTC",
                table: "Hasta");

            migrationBuilder.DropColumn(
                name: "HastaTelefon",
                table: "Hasta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HastaId",
                table: "Randevu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HastaTC",
                table: "Hasta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HastaTelefon",
                table: "Hasta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_HastaId",
                table: "Randevu",
                column: "HastaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_Hasta_HastaId",
                table: "Randevu",
                column: "HastaId",
                principalTable: "Hasta",
                principalColumn: "HastaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
