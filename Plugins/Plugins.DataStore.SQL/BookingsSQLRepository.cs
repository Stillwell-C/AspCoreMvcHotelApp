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
    public class BookingsSQLRepository : IBookingsRepository
    {
        private readonly BookingContext db;

        public BookingsSQLRepository(BookingContext db)
        {
            this.db = db;
        }
        public Booking? AddBooking(Booking booking)
        {
            db.Bookings.Add(booking);
            db.SaveChanges();
            return booking;
        }

        public void DeleteBooking(int bookingId)
        {
            var booking = db.Bookings.Find(bookingId);
            if (booking != null)
            {
                db.Bookings.Remove(booking); 
                db.SaveChanges();
            }
        }

        public Booking? GetBookingById(int bookingId)
        {
            return db.Bookings.Include(x => x.Hotel).FirstOrDefault(x => x.BookingId == bookingId);
        }

        public List<Booking>? GetBookingsByUserId(string userId, bool active)
        {
            var bookings = db.Bookings.Include(x => x.Hotel).Where(x => x.UserId == userId).OrderBy(x => x.EndDate).ToList();
            if (active)
            {
                bookings = bookings.Where(x => x.EndDate >= DateTime.Today).ToList();
            } 
            return bookings;
        }

        public void UpdateBooking(int bookingId, Booking booking)
        {
            if (bookingId != booking.BookingId) return;

            var dbBooking = db.Bookings.Find(bookingId);
            if (dbBooking == null) return;
            
            dbBooking.StartDate = booking.StartDate;
            dbBooking.EndDate = booking.EndDate;
            dbBooking.RoomQuantity = booking.RoomQuantity;
            dbBooking.BookingDayDuration = booking.BookingDayDuration;
            dbBooking.DailyRate = booking.DailyRate;
            dbBooking.RateTotal = booking.RateTotal;
            dbBooking.SpecialRequests = booking.SpecialRequests;

            db.SaveChanges();
        }
    }
}
