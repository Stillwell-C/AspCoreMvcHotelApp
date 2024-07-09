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
    public class DeleteBookingUseCase : IDeleteBookingUseCase
    {
        private readonly IBookingsRepository bookingsRepository;

        public DeleteBookingUseCase(IBookingsRepository bookingsRepository)
        {
            this.bookingsRepository = bookingsRepository;
        }
        public void Execute(int bookingId)
        {
            bookingsRepository.DeleteBooking(bookingId);
        }
    }
}
