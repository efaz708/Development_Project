using Microsoft.AspNetCore.Mvc;

namespace RestaurantManagementSystem.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
