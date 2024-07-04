using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
