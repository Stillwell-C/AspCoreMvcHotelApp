using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.Interfaces;

namespace UseCases.HotelsUseCases
{
    public class AddHotelUseCase : IAddHotelUseCase
    {
        private readonly IHotelsRepository hotelsRepository;

        public AddHotelUseCase(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }
        public void Execute(Hotel hotel)
        {
            hotelsRepository.AddHotel(hotel);
        }
    }
}
