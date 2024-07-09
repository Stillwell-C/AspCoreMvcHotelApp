using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewHotelByIdUseCase
    {
        Hotel? Execute(int hotelId);
    }
}