using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class HotelsSQLRepository : IHotelsRepository
    {
        private readonly BookingContext db;

        public HotelsSQLRepository(BookingContext db)
        {
            this.db = db;
        }
        public void AddHotel(Hotel hotel)
        {
            db.Hotels.Add(hotel);
            db.SaveChanges();
        }

        public void DeleteHotel(int hotelId)
        {
            var hotel = db.Hotels.Find(hotelId);
            if (hotel == null) return;
            db.Hotels.Remove(hotel);
            db.SaveChanges();
        }

        public List<Hotel> GetDealHotels()
        {
            return db.Hotels.OrderBy(x => x.Rates_from).Take(4).ToList();
        }

        public List<Hotel> GetFiveStarHotels()
        {
            return db.Hotels.Where(x => x.Star_rating == 5).Take(4).ToList();
        }

        public Hotel? GetHotelById(int hotelId)
        {
            return db.Hotels.Find(hotelId);
        }

        public List<Hotel> GetHotels()
        {
            return db.Hotels.ToList();
        }

        public List<HotelsByContinent> GetHotelsContinentCount()
        {
            var europeCount = new HotelsByContinent { Name = "Europe", SearchTerm = "europe", Count = db.Hotels.Where(x => x.Continent_name.ToLower() == "europe").Count(), img = db.Hotels.Where(x => x.Continent_name.ToLower() == "europe").First().Photo1 };
            var asiaCount = new HotelsByContinent { Name = "Asia", SearchTerm = "asia", Count = db.Hotels.Where(x => x.Continent_name.ToLower() == "asia").Count(), img = db.Hotels.Where(x => x.Continent_name.ToLower() == "asia").First().Photo1 };
            var americasCount = new HotelsByContinent { Name = "Americas", SearchTerm = "america", Count = db.Hotels.Where(x => x.Continent_name.ToLower().Contains("america")).Count(), img = db.Hotels.Where(x => x.Continent_name.ToLower().Contains("america")).First().Photo1 };

            return [europeCount, asiaCount, americasCount];
        }

        public List<Hotel> GetPopularHotels()
        {
            return db.Hotels.OrderByDescending(x => x.Rating_average).Take(4).ToList();
        }

        public List<Hotel> SearchHotels(string? searchTerm, int? priceMin, int? priceMax)
        {
            List<Hotel> hotels = new List<Hotel>();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                var lowerSearchTerm = searchTerm.ToLower();
                
                hotels = db.Hotels.Where(x =>
                x.Chain_name.ToLower().Contains(lowerSearchTerm) ||
                x.Brand_name.ToLower().Contains(lowerSearchTerm) ||
                x.Hotel_name.ToLower().Contains(lowerSearchTerm) ||
                x.Hotel_formerly_name.ToLower().Contains(lowerSearchTerm) ||
                x.Hotel_translated_name.ToLower().Contains(lowerSearchTerm) ||
                x.Addressline1.ToLower().Contains(lowerSearchTerm) ||
                x.Addressline2.ToLower().Contains(lowerSearchTerm) ||
                x.City.ToLower().Contains(lowerSearchTerm) ||
                x.State.ToLower().Contains(lowerSearchTerm) ||
                x.Country.ToLower().Contains(lowerSearchTerm) ||
                x.Countryisocode.ToLower().Contains(lowerSearchTerm) ||
                x.Overview.ToLower().Contains(lowerSearchTerm) ||
                x.Continent_name.ToLower().Contains(lowerSearchTerm)
                 ).ToList();
            } else
            {
                hotels = this.GetHotels();
            }

            if (priceMin.HasValue)
            {
                hotels = hotels.Where(x => x.Rates_from >= priceMin).ToList();
            }

            if (priceMax.HasValue)
            {
                hotels = hotels.Where(x => x.Rates_from <= priceMax).ToList();
            }

            return hotels;
        }

        public void UpdateHotel(int hotelId, Hotel updatedHotel)
        {
            if (hotelId != updatedHotel.Hotel_id) return;

            var hotel = db.Hotels.Find(hotelId);
            if (hotel == null) return;

            db.Hotels.Update(hotel);
            db.SaveChanges();

        }
    }
}
