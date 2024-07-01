using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.ViewComponents.Default
{
    public class _SubscribePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
