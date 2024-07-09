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
    public class AddBookingUseCase : IAddBookingUseCase
    {
        private readonly IBookingsRepository bookingsRepository;

        public AddBookingUseCase(IBookingsRepository bookingsRepository)
        {
            this.bookingsRepository = bookingsRepository;
        }
        public Booking? Execute(Booking booking)
        {
            return bookingsRepository.AddBooking(booking);
        }
    }
}
