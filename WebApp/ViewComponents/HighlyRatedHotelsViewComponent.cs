using Microsoft.AspNetCore.Mvc;
using UseCases.Interfaces;

namespace WebApp.ViewComponents
{
    [ViewComponent]
    public class HighlyRatedHotelsViewComponent: ViewComponent
    {
        private readonly IViewPopularHotelsUseCase viewPopularHotelsUseCase;

        public HighlyRatedHotelsViewComponent(IViewPopularHotelsUseCase viewPopularHotelsUseCase)
        {
            this.viewPopularHotelsUseCase = viewPopularHotelsUseCase;
        }
        public IViewComponentResult Invoke()
        {
            var hotels = viewPopularHotelsUseCase.Execute();

            return View(hotels);
        }

    }
}
