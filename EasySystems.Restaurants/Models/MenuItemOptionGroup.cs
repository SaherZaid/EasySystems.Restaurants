namespace EasySystems.Restaurants.Models;

public class MenuItemOptionGroup
{
    public int Id { get; set; }

    public int MenuItemId { get; set; }
    public MenuItem? MenuItem { get; set; }

    public string Name { get; set; } = string.Empty;

    public bool IsRequired { get; set; } = true;

    public bool AllowMultiple { get; set; } = false;

    public int SortOrder { get; set; } = 1;

    public bool IsAvailable { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public List<MenuItemOption> Options { get; set; } = [];
    public string GroupType { get; set; } = "SingleChoice";
}