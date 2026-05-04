using EasySystems.Restaurants.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasySystems.Restaurants.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Restaurant> Restaurants { get; set; } = null!;
        public DbSet<MenuCategory> MenuCategories { get; set; } = null!;
        public DbSet<MenuItem> MenuItems { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<RestaurantLegalPage> RestaurantLegalPages { get; set; } = null!;
        public DbSet<MenuItemOption> MenuItemOptions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MenuItem>()
                .Property(x => x.Price)
                .HasPrecision(18, 2);

            builder.Entity<Order>()
                .Property(x => x.TotalAmount)
                .HasPrecision(18, 2);

            builder.Entity<OrderItem>()
                .Property(x => x.UnitPrice)
                .HasPrecision(18, 2);

            builder.Entity<OrderItem>()
                .Property(x => x.LineTotal)
                .HasPrecision(18, 2);

            builder.Entity<MenuItemOption>()
               .Property(x => x.ExtraPrice)
               .HasPrecision(18, 2);
        }
    }
}