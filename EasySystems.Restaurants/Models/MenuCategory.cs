namespace EasySystems.Restaurants.Models;

public class MenuCategory
{
    public int Id { get; set; }

    public int RestaurantId { get; set; }

    public Restaurant? Restaurant { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int SortOrder { get; set; }

    public bool IsVisible { get; set; } = true;
}