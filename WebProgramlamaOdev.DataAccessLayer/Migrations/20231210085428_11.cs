using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramlamaOdev.DataAccessLayer.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Randevu_PoliklinikId",
                table: "Randevu",
                column: "PoliklinikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_Poliklinik_PoliklinikId",
                table: "Randevu",
                column: "PoliklinikId",
                principalTable: "Poliklinik",
                principalColumn: "PoliklinikId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Poliklinik_PoliklinikId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_PoliklinikId",
                table: "Randevu");
        }
    }
}
