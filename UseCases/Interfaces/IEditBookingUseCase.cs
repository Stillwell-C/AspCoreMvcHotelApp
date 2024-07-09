using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IEditBookingUseCase
    {
        void Execute(int bookingId, Booking booking);
    }
}