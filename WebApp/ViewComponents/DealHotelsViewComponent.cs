using Microsoft.AspNetCore.Mvc;
using UseCases.Interfaces;

namespace WebApp.ViewComponents
{
    [ViewComponent]
    public class DealHotelsViewComponent: ViewComponent
    {
        private readonly IViewDealHotelsUseCase viewDealHotelsUseCase;

        public DealHotelsViewComponent(IViewDealHotelsUseCase viewDealHotelsUseCase)
        {
            this.viewDealHotelsUseCase = viewDealHotelsUseCase;
        }
        public IViewComponentResult Invoke()
        {
            var hotels = viewDealHotelsUseCase.Execute();
            return View(hotels);
        }
    }
}
