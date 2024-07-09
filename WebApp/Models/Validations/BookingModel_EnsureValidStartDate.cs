using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Validations
{
    public class BookingModel_EnsureValidStartDate : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var bookingModel = validationContext.ObjectInstance as Booking;

            if (bookingModel != null)
            {
                if (bookingModel.StartDate < bookingModel.CreatedAt)
                {
                    return new ValidationResult("Check in date must be at a later date.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
