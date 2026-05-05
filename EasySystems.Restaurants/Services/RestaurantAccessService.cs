using EasySystems.Restaurants.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace EasySystems.Restaurants.Services;

public class RestaurantAccessService
{
    private readonly ApplicationDbContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public RestaurantAccessService(
        ApplicationDbContext db,
        UserManager<ApplicationUser> userManager)
    {
        _db = db;
        _userManager = userManager;
    }

    public async Task<bool> CanAccessRestaurantAsync(ClaimsPrincipal user, int restaurantId)
    {
        if (user.Identity?.IsAuthenticated != true)
            return false;

        var appUser = await _userManager.GetUserAsync(user);

        if (appUser is null)
            return false;

        if (await _userManager.IsInRoleAsync(appUser, "PlatformSuperAdmin"))
            return true;

        return await _db.RestaurantUserAccesses
            .AnyAsync(x =>
                x.RestaurantId == restaurantId &&
                x.UserId == appUser.Id);
    }

    public async Task<bool> CanManageRestaurantUsersAsync(ClaimsPrincipal user, int restaurantId)
    {
        if (user.Identity?.IsAuthenticated != true)
            return false;

        var appUser = await _userManager.GetUserAsync(user);

        if (appUser is null)
            return false;

        if (await _userManager.IsInRoleAsync(appUser, "PlatformSuperAdmin"))
            return true;

        return await _db.RestaurantUserAccesses
            .AnyAsync(x =>
                x.RestaurantId == restaurantId &&
                x.UserId == appUser.Id &&
                x.Role == "RestaurantOwner");
    }
}