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
    public class EditHotelUseCase : IEditHotelUseCase
    {
        private readonly IHotelsRepository hotelsRepository;

        public EditHotelUseCase(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }
        public void Execute(int hotelId, Hotel updatedHotel)
        {
            hotelsRepository.UpdateHotel(hotelId, updatedHotel);
        }
    }
}
