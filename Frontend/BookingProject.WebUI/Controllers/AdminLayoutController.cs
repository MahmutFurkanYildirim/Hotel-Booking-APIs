using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebUI.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult _AdminLayout()
		{
			return View();
		}
	}
}
