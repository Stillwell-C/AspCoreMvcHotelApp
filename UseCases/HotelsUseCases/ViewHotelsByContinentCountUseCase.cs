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
    public class ViewHotelsByContinentCountUseCase : IViewHotelsByContinentCountUseCase
    {
        private readonly IHotelsRepository hotelsRepository;

        public ViewHotelsByContinentCountUseCase(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }
        public List<HotelsByContinent> Execute()
        {
            return hotelsRepository.GetHotelsContinentCount();
        }
    }
}
