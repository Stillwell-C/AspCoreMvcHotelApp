using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface IViewHotelsByContinentCountUseCase
    {
        List<HotelsByContinent> Execute();
    }
}