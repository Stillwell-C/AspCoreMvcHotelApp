using CoreBusiness;

namespace UseCases.Interfaces
{
    public interface ISearchHotelsUseCase
    {
        List<Hotel> Execute(string searchTerm, int? priceMin, int? priceMax);
    }
}