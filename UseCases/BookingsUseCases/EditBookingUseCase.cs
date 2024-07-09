using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.BookingsUseCases
{
    public class EditBookingUseCase : IEditBookingUseCase
    {
        private readonly IBookingsRepository bookingsRepository;

        public EditBookingUseCase(IBookingsRepository bookingsRepository)
        {
            this.bookingsRepository = bookingsRepository;
        }
        public void Execute(int bookingId, Booking booking)
        {
            bookingsRepository.UpdateBooking(bookingId, booking);
        }
    }
}
