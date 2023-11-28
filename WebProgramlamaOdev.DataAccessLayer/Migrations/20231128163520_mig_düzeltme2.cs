using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramlamaOdev.DataAccessLayer.Migrations
{
    public partial class mig_düzeltme2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Randevu_DoktorId",
                table: "Randevu",
                column: "DoktorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_Doktor_DoktorId",
                table: "Randevu",
                column: "DoktorId",
                principalTable: "Doktor",
                principalColumn: "DoktorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Doktor_DoktorId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_DoktorId",
                table: "Randevu");
        }
    }
}
