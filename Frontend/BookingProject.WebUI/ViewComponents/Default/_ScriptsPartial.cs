using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.ViewComponents.Default
{
    public class _ScriptsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
