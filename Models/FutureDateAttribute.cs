using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantManagementSystem.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime dateValue)
            {
                return dateValue.Date > DateTime.Now.Date;
            }

            return true; // Don't block if the value is invalid type; let [Required] handle that.
        }
    }
}
