using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewBookingsByUserIdUseCase
    {
        List<Booking>? Execute(string userId, bool active);
    }
}