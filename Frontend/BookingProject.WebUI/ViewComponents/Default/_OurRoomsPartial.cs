using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.ViewComponents.Default
{
    public class _OurRoomsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
