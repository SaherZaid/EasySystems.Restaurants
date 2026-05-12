namespace EasySystems.Restaurants.Models;

public class MenuItemOption
{
    public int Id { get; set; }

    public int MenuItemId { get; set; }
    public MenuItem? MenuItem { get; set; }

    public int? MenuItemOptionGroupId { get; set; }
    public MenuItemOptionGroup? MenuItemOptionGroup { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal ExtraPrice { get; set; }

    public bool IsDefaultIncluded { get; set; }

    public bool IsAvailable { get; set; } = true;

    public int SortOrder { get; set; }
}