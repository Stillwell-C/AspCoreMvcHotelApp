using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;




namespace WebApp.ViewModels.Validations
{
    public class BookingViewModel_EnsureValidUserId : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var bookingViewModel = validationContext.ObjectInstance as BookingViewModel;

            if (bookingViewModel != null)
            {
                var contextAccessorService = (IHttpContextAccessor)validationContext.GetService<IHttpContextAccessor>();
                var userConfirmationService = (UserManager<IdentityUser>)validationContext.GetService(typeof(UserManager<IdentityUser>));
                var user = contextAccessorService.HttpContext?.User;
                var userId = userConfirmationService.GetUserId(user);
                if (userId != bookingViewModel.Booking.UserId) {
                    return new ValidationResult("Account validation error. Please try again.");
                }
            }



            return ValidationResult.Success;
        }
    }
}
