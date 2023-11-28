using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramlamaOdev.DataAccessLayer.Migrations
{
    public partial class mig_düzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Doktor_DoktorId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_DoktorId",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "BaslangicSaati",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "BitisSaati",
                table: "Randevu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "BaslangicSaati",
                table: "Randevu",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "BitisSaati",
                table: "Randevu",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

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
    }
}
