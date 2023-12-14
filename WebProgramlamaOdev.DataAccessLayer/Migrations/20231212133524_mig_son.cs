using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramlamaOdev.DataAccessLayer.Migrations
{
    public partial class mig_son : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doktor_AnaBilimDali_AnaBilimDaliId",
                table: "Doktor");

            migrationBuilder.AlterColumn<int>(
                name: "AnaBilimDaliId",
                table: "Doktor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Doktor_AnaBilimDali_AnaBilimDaliId",
                table: "Doktor",
                column: "AnaBilimDaliId",
                principalTable: "AnaBilimDali",
                principalColumn: "AnaBilimDaliId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doktor_AnaBilimDali_AnaBilimDaliId",
                table: "Doktor");

            migrationBuilder.AlterColumn<int>(
                name: "AnaBilimDaliId",
                table: "Doktor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Doktor_AnaBilimDali_AnaBilimDaliId",
                table: "Doktor",
                column: "AnaBilimDaliId",
                principalTable: "AnaBilimDali",
                principalColumn: "AnaBilimDaliId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
