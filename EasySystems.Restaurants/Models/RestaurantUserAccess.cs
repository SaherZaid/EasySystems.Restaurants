using EasySystems.Restaurants.Data;

namespace EasySystems.Restaurants.Models;

public class RestaurantUserAccess
{
    public int Id { get; set; }

    public int RestaurantId { get; set; }
    public Restaurant? Restaurant { get; set; }

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser? User { get; set; }

    public string Role { get; set; } = string.Empty;
    // RestaurantOwner أو RestaurantAdmin

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}