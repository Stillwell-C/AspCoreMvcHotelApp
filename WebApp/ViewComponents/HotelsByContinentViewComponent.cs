using Microsoft.AspNetCore.Mvc;
using UseCases.Interfaces;

namespace WebApp.ViewComponents
{
    [ViewComponent]
    public class HotelsByContinentViewComponent: ViewComponent
    {
        private readonly IViewHotelsByContinentCountUseCase viewHotelsByContinentCountUseCase;

        public HotelsByContinentViewComponent(IViewHotelsByContinentCountUseCase viewHotelsByContinentCountUseCase)
        {
            this.viewHotelsByContinentCountUseCase = viewHotelsByContinentCountUseCase;
        }
        public IViewComponentResult Invoke()
        {
            var hotelsCount = viewHotelsByContinentCountUseCase.Execute();

            return View(hotelsCount);
        }
    }
}
