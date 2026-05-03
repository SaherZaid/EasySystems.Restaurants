namespace EasySystems.Restaurants.Models;

public class Restaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string LogoUrl { get; set; } = string.Empty;

    public string HeroImageUrl { get; set; } = string.Empty;

    public string PrimaryColor { get; set; } = "#8B0000";

    public string SecondaryColor { get; set; } = "#FFFFFF";

    public string Phone { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}