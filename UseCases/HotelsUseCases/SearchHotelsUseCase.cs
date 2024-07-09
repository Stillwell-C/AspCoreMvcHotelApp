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
    public class SearchHotelsUseCase : ISearchHotelsUseCase
    {
        private readonly IHotelsRepository hotelsRepository;

        public SearchHotelsUseCase(IHotelsRepository hotelsRepository)
        {
            this.hotelsRepository = hotelsRepository;
        }
        public List<Hotel> Execute(string searchTerm, int? priceMin, int? priceMax)
        {
            return hotelsRepository.SearchHotels(searchTerm, priceMin, priceMax);
        }
    }
}
