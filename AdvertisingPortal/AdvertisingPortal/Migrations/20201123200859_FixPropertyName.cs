using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvertisingPortal.Migrations
{
    public partial class FixPropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discription",
                table: "Advertisements");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Advertisements",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Advertisements");

            migrationBuilder.AddColumn<string>(
                name: "Discription",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
