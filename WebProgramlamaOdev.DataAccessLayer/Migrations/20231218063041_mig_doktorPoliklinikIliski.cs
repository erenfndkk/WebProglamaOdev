using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramlamaOdev.DataAccessLayer.Migrations
{
    public partial class mig_doktorPoliklinikIliski : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PoliklinikId",
                table: "Doktor",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Doktor_PoliklinikId",
                table: "Doktor",
                column: "PoliklinikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doktor_Poliklinik_PoliklinikId",
                table: "Doktor",
                column: "PoliklinikId",
                principalTable: "Poliklinik",
                principalColumn: "PoliklinikId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doktor_Poliklinik_PoliklinikId",
                table: "Doktor");

            migrationBuilder.DropIndex(
                name: "IX_Doktor_PoliklinikId",
                table: "Doktor");

            migrationBuilder.DropColumn(
                name: "PoliklinikId",
                table: "Doktor");
        }
    }
}
