using System.ComponentModel.DataAnnotations;
using UseCases.Interfaces;

namespace WebApp.ViewModels.Validations
{
    public class BookingViewModel_EnsureValidDailyRate : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var bookingViewModel = validationContext.ObjectInstance as BookingViewModel;

            if (bookingViewModel != null)
            {
                if (bookingViewModel.Booking.DailyRate < 1)
                {
                    return new ValidationResult("Invalid nightly rate. Please try again.");
                }

                var rateConfirmationService = (IViewHotelByIdUseCase) validationContext.GetService(typeof(IViewHotelByIdUseCase));
                var rateConfirmation = rateConfirmationService.Execute(bookingViewModel.Booking.HotelId);
                if (rateConfirmation != null && bookingViewModel.Booking.DailyRate != rateConfirmation.Rates_from)
                {
                    return new ValidationResult("Invalid nightly rate. Please try again.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
