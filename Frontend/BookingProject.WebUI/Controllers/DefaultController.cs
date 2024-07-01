using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
