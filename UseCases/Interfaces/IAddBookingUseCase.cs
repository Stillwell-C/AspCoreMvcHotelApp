using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IAddBookingUseCase
    {
        Booking? Execute(Booking booking);
    }
}