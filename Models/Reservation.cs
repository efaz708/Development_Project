using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RestaurantManagementSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify number of people")]
        [Range(1, 20, ErrorMessage = "Enter a value between 1 and 20")]
        public int NumberOfPeople { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "The date must be in the future.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Time is required")]
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }

        [BindNever]
        public string? UserId { get; set; }

        [ValidateNever]
        public IdentityUser User { get; set; }
        public int? TableNumber { get; set; }


    }
}

