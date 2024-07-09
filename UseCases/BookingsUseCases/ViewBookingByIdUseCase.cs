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
    public class ViewBookingByIdUseCase : IViewBookingByIdUseCase
    {
        private readonly IBookingsRepository bookingsRepository;

        public ViewBookingByIdUseCase(IBookingsRepository bookingsRepository)
        {
            this.bookingsRepository = bookingsRepository;
        }
        public Booking? Execute(int bookingId)
        {
            return bookingsRepository.GetBookingById(bookingId);
        }
    }
}
