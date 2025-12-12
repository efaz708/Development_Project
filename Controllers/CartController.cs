using Microsoft.AspNetCore.Mvc;
using RestaurantManagementSystem.Data;
using RestaurantManagementSystem.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestaurantManagementSystem.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CartController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var isAdmin = User.Identity.Name == "admin@gmail.com";

            var cartItems = isAdmin
                ? await _context.CartItems.Include(c => c.User).ToListAsync()
                : await _context.CartItems.Where(c => c.UserId == userId).Include(c => c.User).ToListAsync();

            var reservations = isAdmin
                ? await _context.Reservations.Include(r => r.User).ToListAsync()
                : await _context.Reservations.Where(r => r.UserId == userId).Include(r => r.User).ToListAsync();

            ViewBag.Reservations = reservations;
            ViewBag.IsAdmin = isAdmin;
            return View(cartItems);
        }




        [HttpPost]
        public async Task<IActionResult> AddToCart(List<int> selectedItemIds)
        {
            var userId = _userManager.GetUserId(User);

            var items = _context.MenuItems
                        .Where(m => selectedItemIds.Contains(m.Id))
                        .ToList();

            foreach (var item in items)
            {
                var existing = _context.CartItems.FirstOrDefault(c => c.UserId == userId && c.ItemName == item.Name);
                if (existing != null)
                {
                    existing.Quantity += 1;
                }
                else
                {
                    _context.CartItems.Add(new CartItem
                    {
                        UserId = userId,
                        ItemName = item.Name,
                        Price = item.Price,
                        Quantity = 1
                    });
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCart(List<CartItem> CartItems)
        {
            var userId = _userManager.GetUserId(User);

            foreach (var item in CartItems)
            {
                var cartItem = _context.CartItems.FirstOrDefault(c => c.Id == item.Id && c.UserId == userId);
                if (cartItem != null)
                {
                    cartItem.Quantity = item.Quantity;
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var userId = _userManager.GetUserId(User);
            var item = await _context.CartItems.FindAsync(id);

            if (item == null)
                return NotFound();

            // ✅ If not admin, check user ownership
            if (!User.IsInRole("Admin") && item.UserId != userId)
                return Forbid();

            _context.CartItems.Remove(item);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        private bool IsAdminUser()
        {
            return User.Identity != null && User.Identity.Name == "admin@gmail.com";
        }
    }
}
