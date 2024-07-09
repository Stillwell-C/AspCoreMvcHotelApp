using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class BookingsInMemoryRepository : IBookingsRepository
    {
        private List<Booking> _bookings = new List<Booking>();
        
        public Booking? AddBooking(Booking booking)
        {
            var id = 1;
            var lastItem = _bookings.LastOrDefault();
            if (lastItem != null)
            {
                id = lastItem.BookingId + 1;
            }

            booking.BookingId = id;
            _bookings.Add(booking);

            return booking;
        }

        public void DeleteBooking(int bookingId)
        {
            throw new NotImplementedException();
        }

        public Booking? GetBookingById(int bookingId)
        {
            throw new NotImplementedException();
        }

        public List<Booking>? GetBookingsByUserId(string userId, bool active)
        {
            throw new NotImplementedException();
        }

        public void UpdateBooking(int bookingId, Booking booking)
        {
            throw new NotImplementedException();
        }
    }
}
