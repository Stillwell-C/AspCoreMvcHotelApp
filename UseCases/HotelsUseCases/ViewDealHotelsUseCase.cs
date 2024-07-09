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
    public class ViewDealHotelsUseCase : IViewDealHotelsUseCase
    {
        private readonly IHotelsRepository hotelsRepository;

        public ViewDealHotelsUseCase(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }
        public List<Hotel> Execute()
        {
            return hotelsRepository.GetDealHotels();
        }
    }
}
