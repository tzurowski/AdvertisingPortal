using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvertisingPortal.Migrations
{
    public partial class IncludeCarToAdvertisement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_Cars_CarId",
                table: "Advertisements");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_CarId",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Advertisements");

            migrationBuilder.AddColumn<int>(
                name: "AdvertisementId",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_AdvertisementId",
                table: "Cars",
                column: "AdvertisementId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Advertisements_AdvertisementId",
                table: "Cars",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "AdvertisementId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Advertisements_AdvertisementId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_AdvertisementId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "AdvertisementId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Advertisements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_CarId",
                table: "Advertisements",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_Cars_CarId",
                table: "Advertisements",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
