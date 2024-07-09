using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Validations
{
    public class BookingModel_EnsureValidDailyRate : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var bookingModel = validationContext.ObjectInstance as Booking;

            if (bookingModel != null)
            {
                if (bookingModel.DailyRate < 1)
                {
                    return new ValidationResult("Invalid nightly rate. Please try again.");
                } 
                var rateConfirmation = HotelsRepository.GetHotel(bookingModel.HotelId);
                if (bookingModel.DailyRate != rateConfirmation.Rates_from)
                {
                    return new ValidationResult("Invalid nightly rate. Please try again.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
