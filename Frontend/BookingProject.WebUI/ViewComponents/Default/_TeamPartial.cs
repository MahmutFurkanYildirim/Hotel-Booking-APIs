using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.ViewComponents.Default
{
    public class _TeamPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
