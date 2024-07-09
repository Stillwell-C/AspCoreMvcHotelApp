using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Validations
{
    public class BookingModel_EnsureValidEndDate : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var bookingModel = validationContext.ObjectInstance as Booking;

            if (bookingModel != null)
            {
                if (bookingModel.StartDate > bookingModel.EndDate)
                {
                    return new ValidationResult("Check out date must be after start date.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
