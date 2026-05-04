using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasySystems.Restaurants.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantNavbarFooterColors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FooterTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FooterTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarTextColor",
                table: "Restaurants");
        }
    }
}
