using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Web;
using UseCases.Interfaces;
using CoreBusiness;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IAddHotelUseCase addHotelUseCase;
        private readonly IDeleteHotelUseCase deleteHotelUseCase;
        private readonly IEditHotelUseCase editHotelUseCase;
        private readonly ISearchHotelsUseCase searchHotelsUseCase;
        private readonly IViewHotelByIdUseCase viewHotelByIdUseCase;
        private readonly IViewHotelsUseCase viewHotelsUseCase;

        public HotelsController(IAddHotelUseCase addHotelUseCase, IDeleteHotelUseCase deleteHotelUseCase, IEditHotelUseCase editHotelUseCase, ISearchHotelsUseCase searchHotelsUseCase, IViewHotelByIdUseCase viewHotelByIdUseCase, IViewHotelsUseCase viewHotelsUseCase)
        {
            this.addHotelUseCase = addHotelUseCase;
            this.deleteHotelUseCase = deleteHotelUseCase;
            this.editHotelUseCase = editHotelUseCase;
            this.searchHotelsUseCase = searchHotelsUseCase;
            this.viewHotelByIdUseCase = viewHotelByIdUseCase;
            this.viewHotelsUseCase = viewHotelsUseCase;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAll ()
        {
            var hotels = viewHotelsUseCase.Execute();
            var viewModel = new HotelSearchViewModel
            {
                Hotels = hotels,
            };
            ViewBag.PageTitle = "Browse Hotels";
            return View("Search", viewModel);
        }

        public IActionResult ViewHotel (int id)
        {
            var hotel = viewHotelByIdUseCase.Execute(id);
            ViewBag.PageTitle = hotel.Hotel_name;
            return View(hotel);
        }

        public IActionResult Search(string? searchTerm, string? startDate, string? endDate, int? minPrice, int ? maxPrice, int? roomQuantity, HotelSearch hotelSearch)
        {
            
            var hotels = searchHotelsUseCase.Execute(searchTerm, minPrice, maxPrice);

            var viewModel = new HotelSearchViewModel
            {
                Hotels = hotels,
                HotelSearch = hotelSearch
            };

            ViewBag.PageTitle = searchTerm != null ? $"{searchTerm} | Hotel Search" : "Hotel Search";
            
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Search(HotelSearch hotelSearch)
        {
            if (ModelState.IsValid)
            {
                dynamic routeValues = new ExpandoObject();
                routeValues.searchterm = hotelSearch.SearchTerm;
                if (hotelSearch.MinPrice != null) routeValues.MinPrice = hotelSearch.MinPrice;
                if (hotelSearch.MaxPrice != null) routeValues.MaxPrice = hotelSearch.MaxPrice;
                if (hotelSearch.StartDate.HasValue) routeValues.StartDate = hotelSearch.StartDate.Value.ToString("yyyy-MM-dd");
                if (hotelSearch.EndDate.HasValue) routeValues.EndDate = hotelSearch.EndDate.Value.ToString("yyyy-MM-dd");
                if (hotelSearch.RoomQuantity.HasValue) routeValues.RoomQuantity = hotelSearch.RoomQuantity;

                return RedirectToAction("Search", routeValues);
            }
            return RedirectToAction("Search", new { id = "ViewAll" });
        }
    }
}
