using EasySystems.Restaurants.Components;
using EasySystems.Restaurants.Components.Account;
using EasySystems.Restaurants.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EasySystems.Restaurants.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
.AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddScoped<RestaurantAccessService>();

builder.Services.AddIdentityCore<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddSignInManager()
.AddDefaultTokenProviders();


builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddTransient<IEmailSender<ApplicationUser>, SmtpEmailSender>();

var app = builder.Build();

// Seed roles and platform super admin
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

    string[] roles =
    {
        "PlatformSuperAdmin",
        "RestaurantOwner",
        "RestaurantAdmin",
        "Customer"
    };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    string superAdminEmail = "saherzaid1997@gmail.com";
    string superAdminPassword = "Ss0502779727!";

    var superAdmin = await userManager.FindByEmailAsync(superAdminEmail);

    if (superAdmin is null)
    {
        superAdmin = new ApplicationUser
        {
            UserName = superAdminEmail,
            Email = superAdminEmail,
            EmailConfirmed = true
        };

        var createResult = await userManager.CreateAsync(superAdmin, superAdminPassword);

        if (createResult.Succeeded)
        {
            await userManager.AddToRoleAsync(superAdmin, "PlatformSuperAdmin");
        }
    }
    else
    {
        if (!await userManager.IsInRoleAsync(superAdmin, "PlatformSuperAdmin"))
        {
            await userManager.AddToRoleAsync(superAdmin, "PlatformSuperAdmin");
        }
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();

// Redirect homepage before Blazor loads
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        context.Response.Redirect("/restaurant/goteborg-mat-grill");
        return;
    }

    await next();
});

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapPost("/Account/RestaurantLogout", async (
    SignInManager<ApplicationUser> signInManager,
    [FromForm] string? returnUrl) =>
{
    await signInManager.SignOutAsync();

    if (string.IsNullOrWhiteSpace(returnUrl))
    {
        return Results.Redirect("/");
    }

    if (!returnUrl.StartsWith("/"))
    {
        return Results.Redirect("/");
    }

    if (returnUrl.StartsWith("//"))
    {
        return Results.Redirect("/");
    }

    return Results.Redirect(returnUrl);
});

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.Run();