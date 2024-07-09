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
    public class ViewHotelByIdUseCase : IViewHotelByIdUseCase
    {
        private readonly IHotelsRepository hotelsRepository;

        public ViewHotelByIdUseCase(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }
        public Hotel? Execute(int hotelId)
        {
            return hotelsRepository.GetHotelById(hotelId);
        }
    }
}
