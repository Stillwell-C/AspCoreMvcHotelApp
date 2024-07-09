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
    public class ViewBookingsByUserIdUseCase : IViewBookingsByUserIdUseCase
    {
        private readonly IBookingsRepository bookingsRepository;

        public ViewBookingsByUserIdUseCase(IBookingsRepository bookingsRepository)
        {
            this.bookingsRepository = bookingsRepository;
        }
        public List<Booking>? Execute(string userId, bool active)
        {
            return bookingsRepository.GetBookingsByUserId(userId, active);
        }
    }
}
