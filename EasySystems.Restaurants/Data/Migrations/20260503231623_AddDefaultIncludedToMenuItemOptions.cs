using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasySystems.Restaurants.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultIncludedToMenuItemOptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefaultIncluded",
                table: "MenuItemOptions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefaultIncluded",
                table: "MenuItemOptions");
        }
    }
}
