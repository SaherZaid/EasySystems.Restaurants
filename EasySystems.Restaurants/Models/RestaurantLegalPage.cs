namespace EasySystems.Restaurants.Models;

public class RestaurantLegalPage
{
    public int Id { get; set; }

    public int RestaurantId { get; set; }
    public Restaurant? Restaurant { get; set; }

    public string PageType { get; set; } = string.Empty;
    // Privacy أو Terms

    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public bool IsPublished { get; set; } = true;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}