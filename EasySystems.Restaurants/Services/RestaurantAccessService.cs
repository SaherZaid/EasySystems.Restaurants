using EasySystems.Restaurants.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace EasySystems.Restaurants.Services;

public class RestaurantAccessService
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbFactory;
    private readonly UserManager<ApplicationUser> _userManager;

    public RestaurantAccessService(
        IDbContextFactory<ApplicationDbContext> dbFactory,
        UserManager<ApplicationUser> userManager)
    {
        _dbFactory = dbFactory;
        _userManager = userManager;
    }

    public async Task<bool> IsPlatformSuperAdminAsync(ClaimsPrincipal user)
    {
        if (user.Identity?.IsAuthenticated != true)
            return false;

        var appUser = await _userManager.GetUserAsync(user);

        if (appUser is null)
            return false;

        return await _userManager.IsInRoleAsync(appUser, "PlatformSuperAdmin");
    }

    public async Task<bool> CanCreateRestaurantsAsync(ClaimsPrincipal user)
    {
        return await IsPlatformSuperAdminAsync(user);
    }

    public async Task<bool> CanAccessRestaurantAsync(ClaimsPrincipal user, int restaurantId)
    {
        if (await IsPlatformSuperAdminAsync(user))
            return true;

        var appUser = await _userManager.GetUserAsync(user);

        if (appUser is null)
            return false;

        await using var db = await _dbFactory.CreateDbContextAsync();

        return await db.RestaurantUserAccesses
            .AsNoTracking()
            .AnyAsync(x =>
                x.RestaurantId == restaurantId &&
                x.UserId == appUser.Id);
    }

    public async Task<bool> CanManageRestaurantUsersAsync(ClaimsPrincipal user, int restaurantId)
    {
        return await HasRestaurantRoleAsync(
            user,
            restaurantId,
            allowedRoles: ["RestaurantOwner"]);
    }

    public async Task<bool> CanManageRestaurantSettingsAsync(ClaimsPrincipal user, int restaurantId)
    {
        return await HasRestaurantRoleAsync(
            user,
            restaurantId,
            allowedRoles: ["RestaurantOwner"]);
    }

    public async Task<bool> CanManageRestaurantLegalAsync(ClaimsPrincipal user, int restaurantId)
    {
        return await HasRestaurantRoleAsync(
            user,
            restaurantId,
            allowedRoles: ["RestaurantOwner"]);
    }

    public async Task<bool> CanManageRestaurantMenuAsync(ClaimsPrincipal user, int restaurantId)
    {
        return await HasRestaurantRoleAsync(
            user,
            restaurantId,
            allowedRoles: ["RestaurantOwner", "RestaurantAdmin"]);
    }

    public async Task<bool> CanManageRestaurantOrdersAsync(ClaimsPrincipal user, int restaurantId)
    {
        return await HasRestaurantRoleAsync(
            user,
            restaurantId,
            allowedRoles: ["RestaurantOwner", "RestaurantAdmin"]);
    }

    private async Task<bool> HasRestaurantRoleAsync(
        ClaimsPrincipal user,
        int restaurantId,
        string[] allowedRoles)
    {
        if (await IsPlatformSuperAdminAsync(user))
            return true;

        if (user.Identity?.IsAuthenticated != true)
            return false;

        var appUser = await _userManager.GetUserAsync(user);

        if (appUser is null)
            return false;

        await using var db = await _dbFactory.CreateDbContextAsync();

        return await db.RestaurantUserAccesses
            .AsNoTracking()
            .AnyAsync(x =>
                x.RestaurantId == restaurantId &&
                x.UserId == appUser.Id &&
                allowedRoles.Contains(x.Role));
    }
}