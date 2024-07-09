using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IEditHotelUseCase
    {
        void Execute(int hotelId, Hotel updatedHotel);
    }
}