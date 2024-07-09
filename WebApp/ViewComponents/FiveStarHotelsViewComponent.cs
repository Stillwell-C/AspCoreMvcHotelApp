using Microsoft.AspNetCore.Mvc;
using UseCases.Interfaces;

namespace WebApp.ViewComponents
{
    [ViewComponent]
    public class FiveStarHotelsViewComponent: ViewComponent
    {
        private readonly IViewFiveStarHotelsUseCase viewFiveStarHotelsUseCase;

        public FiveStarHotelsViewComponent(IViewFiveStarHotelsUseCase viewFiveStarHotelsUseCase)
        {
            this.viewFiveStarHotelsUseCase = viewFiveStarHotelsUseCase;
        }
        public IViewComponentResult Invoke()
        {
            var hotels = viewFiveStarHotelsUseCase.Execute();
            return View(hotels);
        }
    }
}
