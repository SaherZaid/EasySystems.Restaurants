using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasySystems.Restaurants.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantDesignColors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BodyTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ButtonBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ButtonTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CartBarBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CartBarTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HeadingTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HeroOverlayColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HeroTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MenuCategoryBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MenuItemBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MutedTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PageBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PriceTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondaryButtonBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecondaryButtonTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SectionBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ButtonBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ButtonTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "CardBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "CartBarBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "CartBarTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "HeadingTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "HeroOverlayColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "HeroTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "MenuCategoryBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "MenuItemBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "MutedTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "PageBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "PriceTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "SecondaryButtonBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "SecondaryButtonTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "SectionBackgroundColor",
                table: "Restaurants");
        }
    }
}
