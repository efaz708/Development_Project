using System.ComponentModel.DataAnnotations;
using RestaurantManagementSystem.Models;


namespace RestaurantManagementSystem.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(0.01, 1000)]
        public decimal Price { get; set; }

        public string Category { get; set; }  // e.g., Food, Drink, Dessert
    }
}
