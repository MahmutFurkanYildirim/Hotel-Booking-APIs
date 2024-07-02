using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
