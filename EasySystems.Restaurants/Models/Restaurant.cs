using EasySystems.Restaurants.Data;

namespace EasySystems.Restaurants.Models;

public class Restaurant
{
    public int Id { get; set; }

    public string? OwnerUserId { get; set; }
    public ApplicationUser? OwnerUser { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string LogoUrl { get; set; } = string.Empty;
    public string HeroImageUrl { get; set; } = string.Empty;

    public string PrimaryColor { get; set; } = "#8B0000";
    public string SecondaryColor { get; set; } = "#FFFFFF";

    public string NavbarBackgroundColor { get; set; } = "#FFFFFF";
    public string NavbarTextColor { get; set; } = "#111827";
    public string FooterBackgroundColor { get; set; } = "#111827";
    public string FooterTextColor { get; set; } = "#FFFFFF";

    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    public string FacebookUrl { get; set; } = string.Empty;
    public string InstagramUrl { get; set; } = string.Empty;
    public string TikTokUrl { get; set; } = string.Empty;
    public string WebsiteUrl { get; set; } = string.Empty;

    public string MondayHours { get; set; } = string.Empty;
    public string TuesdayHours { get; set; } = string.Empty;
    public string WednesdayHours { get; set; } = string.Empty;
    public string ThursdayHours { get; set; } = string.Empty;
    public string FridayHours { get; set; } = string.Empty;
    public string SaturdayHours { get; set; } = string.Empty;
    public string SundayHours { get; set; } = string.Empty;

    public bool IsPickupEnabled { get; set; } = true;
    public bool IsDeliveryEnabled { get; set; } = false;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}