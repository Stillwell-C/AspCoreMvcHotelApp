using System.ComponentModel.DataAnnotations;
using UseCases.Interfaces;

namespace WebApp.ViewModels.Validations
{
    public class BookingViewModel_EnsureValidStartDate : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var bookingViewModel = validationContext.ObjectInstance as BookingViewModel;

            if (bookingViewModel != null)
            {
                //Ensure that no bookings are made for past dates relative to hotel's time zone
                //Get Hotel
                var hotelConfirmationService = (IViewHotelByIdUseCase)validationContext.GetService(typeof(IViewHotelByIdUseCase));
                var hotelConfirmation = hotelConfirmationService.Execute(bookingViewModel.Booking.HotelId);
                //Convert hotel timezone to TZInfo
                var tz = TimeZoneInfo.FindSystemTimeZoneById(hotelConfirmation.Timezone);
                //Convert CreatedAt to hotel's time zone
                var adjustedLocationDate = TimeZoneInfo.ConvertTimeFromUtc(bookingViewModel.Booking.CreatedAt, tz);
                //Ensure that start date is not less than date of booking
                if (bookingViewModel.Booking.StartDate.Date < adjustedLocationDate.Date)
                {
                    return new ValidationResult("Check in date must be at a later date.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
