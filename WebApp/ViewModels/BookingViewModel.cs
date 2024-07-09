using CoreBusiness;
using WebApp.ViewModels.Validations;

namespace WebApp.ViewModels
{
    public class BookingViewModel
    {
        public Hotel Hotel { get; set; } = new Hotel();
        [BookingViewModel_EnsureValidDailyRate]
        [BookingViewModel_EnsureValidTotalRate]
        [BookingViewModel_EnsureValidUserId]
        [BookingViewModel_EnsureValidStartDate]
        public Booking Booking { get; set; } = new Booking();
    }
}
