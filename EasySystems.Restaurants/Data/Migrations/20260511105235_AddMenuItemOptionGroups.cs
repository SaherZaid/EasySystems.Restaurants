using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasySystems.Restaurants.Migrations
{
    /// <inheritdoc />
    public partial class AddMenuItemOptionGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuItemOptionGroupId",
                table: "MenuItemOptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MenuItemOptionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    AllowMultiple = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItemOptionGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItemOptionGroups_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemOptions_MenuItemOptionGroupId",
                table: "MenuItemOptions",
                column: "MenuItemOptionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItemOptionGroups_MenuItemId",
                table: "MenuItemOptionGroups",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItemOptions_MenuItemOptionGroups_MenuItemOptionGroupId",
                table: "MenuItemOptions",
                column: "MenuItemOptionGroupId",
                principalTable: "MenuItemOptionGroups",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItemOptions_MenuItemOptionGroups_MenuItemOptionGroupId",
                table: "MenuItemOptions");

            migrationBuilder.DropTable(
                name: "MenuItemOptionGroups");

            migrationBuilder.DropIndex(
                name: "IX_MenuItemOptions_MenuItemOptionGroupId",
                table: "MenuItemOptions");

            migrationBuilder.DropColumn(
                name: "MenuItemOptionGroupId",
                table: "MenuItemOptions");
        }
    }
}
