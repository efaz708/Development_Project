using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace RestaurantManagementSystem.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
