using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantManagementSystem.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public decimal Total => Price * Quantity;

        [Required]
        public string UserId { get; set; } // Link to Identity user
        public IdentityUser User { get; set; }
    }
}
