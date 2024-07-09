using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IBookingsRepository
    {
        Booking? AddBooking(Booking booking);
        void DeleteBooking(int bookingId);
        void UpdateBooking(int bookingId, Booking booking);
        Booking? GetBookingById(int bookingId);
        List<Booking>? GetBookingsByUserId(string userId, bool active);
    }
}