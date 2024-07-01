using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.ViewComponents.Default
{
    public class _CarouselPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
