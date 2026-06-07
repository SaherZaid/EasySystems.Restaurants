using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasySystems.Restaurants.Migrations
{
    /// <inheritdoc />
    public partial class AddRestaurantAdvancedDesignSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FooterBorderColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FooterCopyrightText",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FooterDescription",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FooterHeadingColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FooterLinkColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FooterLinkHoverColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FooterMutedTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FooterTitle",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarActiveBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarActiveTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarBorderColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NavbarBorderRadius",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NavbarBrandSubtitleColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarBrandTitleColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarButtonBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarButtonTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NavbarHeight",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "NavbarIsFloating",
                table: "Restaurants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NavbarIsSticky",
                table: "Restaurants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NavbarLinkHoverColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarLogoBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NavbarLogoSize",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NavbarLogoTextColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarMobileBackgroundColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NavbarShadowColor",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowFooterLegalLinks",
                table: "Restaurants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowFooterLogo",
                table: "Restaurants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowFooterSocialLinks",
                table: "Restaurants",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FooterBorderColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FooterCopyrightText",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FooterDescription",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FooterHeadingColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FooterLinkColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FooterLinkHoverColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FooterMutedTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FooterTitle",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarActiveBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarActiveTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarBorderColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarBorderRadius",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarBrandSubtitleColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarBrandTitleColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarButtonBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarButtonTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarHeight",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarIsFloating",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarIsSticky",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarLinkHoverColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarLogoBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarLogoSize",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarLogoTextColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarMobileBackgroundColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "NavbarShadowColor",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ShowFooterLegalLinks",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ShowFooterLogo",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ShowFooterSocialLinks",
                table: "Restaurants");
        }
    }
}
