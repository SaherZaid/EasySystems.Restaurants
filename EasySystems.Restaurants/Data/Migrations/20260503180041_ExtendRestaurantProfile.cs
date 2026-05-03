using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasySystems.Restaurants.Migrations
{
    /// <inheritdoc />
    public partial class ExtendRestaurantProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FridayHours",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InstagramUrl",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeliveryEnabled",
                table: "Restaurants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPickupEnabled",
                table: "Restaurants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MondayHours",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SaturdayHours",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SundayHours",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ThursdayHours",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TikTokUrl",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TuesdayHours",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WebsiteUrl",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WednesdayHours",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FridayHours",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "InstagramUrl",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "IsDeliveryEnabled",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "IsPickupEnabled",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "MondayHours",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "SaturdayHours",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "SundayHours",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ThursdayHours",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "TikTokUrl",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "TuesdayHours",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "WebsiteUrl",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "WednesdayHours",
                table: "Restaurants");
        }
    }
}
