using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IHotelsRepository
    {
        void AddHotel(Hotel hotel);
        void DeleteHotel(int hotelId);
        List<Hotel> GetDealHotels();
        List<Hotel> GetFiveStarHotels();
        Hotel? GetHotelById(int hotelId);
        List<Hotel> GetHotels();
        List<HotelsByContinent> GetHotelsContinentCount();
        List<Hotel> GetPopularHotels();
        List<Hotel> SearchHotels(string searchTerm, int? priceMin, int? priceMax);
        void UpdateHotel(int hotelId, Hotel updatedHotel);
    }
}