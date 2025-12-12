// Data/AdminSeeder.cs
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.Data
{
    public static class AdminSeeder
    {
        public static async Task SeedAdminAsync(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

                var adminEmail = "admin@gmail.com";
                var adminPassword = "Admin@1234"; 


                // ✅ Create role if it doesn't exist
                if (!await roleManager.RoleExistsAsync("Admin"))
                {
                    await roleManager.CreateAsync(new IdentityRole("Admin"));
                }

                var existingAdmin = await userManager.FindByEmailAsync(adminEmail);
                if (existingAdmin == null)
                {
                    var newAdmin = new IdentityUser
                    {
                        UserName = adminEmail,
                        Email = adminEmail,
                        EmailConfirmed = true
                    };

                    var result = await userManager.CreateAsync(newAdmin, adminPassword);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(newAdmin, "Admin");
                        Console.WriteLine("✅ Admin created and assigned to Admin role.");
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


    }
}
