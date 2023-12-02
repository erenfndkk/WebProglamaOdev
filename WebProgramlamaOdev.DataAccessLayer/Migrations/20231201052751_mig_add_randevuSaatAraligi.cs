using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProgramlamaOdev.DataAccessLayer.Migrations
{
    public partial class mig_add_randevuSaatAraligi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SaatAraligi",
                table: "Randevu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaatAraligi",
                table: "Randevu");
        }
    }
}
