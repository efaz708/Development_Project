using RestaurantManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Configure EF Core + SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Allow strong passwords like "Admin@1234"
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
});

// Add Identity
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<ApplicationDbContext>();

// Add MVC services
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages(); // Required for Identity UI

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Welcome}/{action=Index}/{id?}");

app.MapRazorPages();

// SEED ADMIN
await RestaurantManagementSystem.Data.AdminSeeder.SeedAdminAsync(app);
app.Run();


// 🔽 Move your admin seeding logic here
static async Task SeedAdminAsync(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var services = scope.ServiceProvider;

    try
    {
        var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
        var adminEmail = "admin@gmail.com";
var adminPassword = Environment.GetEnvironmentVariable("ADMIN_SEED_PASSWORD");
        var existingAdmin = await userManager.FindByEmailAsync(adminEmail);
        if (existingAdmin == null)
        {
            var newAdmin = new IdentityUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                EmailConfirmed = true
            };

            if (string.IsNullOrWhiteSpace(adminPassword))
{
    Console.WriteLine("Admin seeding skipped: ADMIN_SEED_PASSWORD is not configured.");
    return;
}

var result = await userManager.CreateAsync(newAdmin, adminPassword);
            if (result.Succeeded)
            {
                Console.WriteLine("✅ Admin user created successfully.");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"❌ Error: {error.Description}");
                }
            }
        }
        else
        {
            Console.WriteLine("ℹ️ Admin already exists.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❗ Admin seeding failed: {ex.Message}");
    }
}
