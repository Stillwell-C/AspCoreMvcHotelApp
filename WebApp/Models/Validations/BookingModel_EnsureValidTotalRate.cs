using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Validations
{
    public class BookingModel_EnsureValidTotalRate : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var bookingModel = validationContext.ObjectInstance as Booking;

            if (bookingModel != null)
            {
                if (bookingModel.RateTotal < 1)
                {
                    return new ValidationResult("Invalid total rate. Please try again.");
                }
                var rateConfirmation = HotelsRepository.GetHotel(bookingModel.HotelId);
                if (bookingModel.RateTotal != (rateConfirmation.Rates_from * bookingModel.BookingDayDuration))
                {
                    return new ValidationResult("Invalid total rate. Please try again.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
