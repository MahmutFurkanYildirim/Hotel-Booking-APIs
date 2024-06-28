using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
