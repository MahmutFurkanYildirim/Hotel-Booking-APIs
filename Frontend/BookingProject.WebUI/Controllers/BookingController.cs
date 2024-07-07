using BookingProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BookingProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {

            if (!ModelState.IsValid)
            {
                // Model state hatalarını kullanıcıya gösterin
                return View(createBookingDto);
            }

            createBookingDto.Status = "Waiting for approval";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("http://localhost:5250/api/Bookin", stringContent);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                var statusCode = response.StatusCode;
                var reasonPhrase = response.ReasonPhrase;
                var error = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"API call failed. Status Code: {statusCode}, Reason: {reasonPhrase}, Error: {error}");

                ModelState.AddModelError(string.Empty, $"API call failed: Status Code: {statusCode}, Reason: {reasonPhrase}");
                return View(createBookingDto);
            }
        }

    }
}
