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
    public class ViewPopularHotelsUseCase : IViewPopularHotelsUseCase
    {
        private readonly IHotelsRepository hotelsRepository;

        public ViewPopularHotelsUseCase(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }
        public List<Hotel> Execute()
        {
            return hotelsRepository.GetPopularHotels();
        }
    }
}
