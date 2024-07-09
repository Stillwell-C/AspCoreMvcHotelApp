using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewBookingByIdUseCase
    {
        Booking? Execute(int bookingId);
    }
}