using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Data;
using System.Linq;
using Microsoft.AspNetCore.Authorization;


namespace RestaurantManagementSystem.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Menu()
        {
            var items = _context.MenuItems.ToList();
            return View(items);
        }
        private bool IsAdminUser()
        {
            return User.Identity != null && User.Identity.Name == "admin@gmail.com";
        }

    }
}
