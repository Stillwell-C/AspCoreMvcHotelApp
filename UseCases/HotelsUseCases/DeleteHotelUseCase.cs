using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.HotelsUseCases
{
    public class DeleteHotelUseCase : IDeleteHotelUseCase
    {
        private readonly IHotelsRepository hotelsRepository;

        public DeleteHotelUseCase(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }
        public void Execute(int hotelId)
        {
            hotelsRepository.DeleteHotel(hotelId);
        }
    }
}
