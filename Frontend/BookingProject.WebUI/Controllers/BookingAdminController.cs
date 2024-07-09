using BookingProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BookingProject.WebUI.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookingAdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5250/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> ApprovedReservation(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var BookingResponse = await client.GetAsync($"http://localhost:5250/api/Booking/{id}");
            if (BookingResponse.IsSuccessStatusCode)
            {
                var BookingJsonData = await BookingResponse.Content.ReadAsStringAsync();
                var Booking = JsonConvert.DeserializeObject<UpdateBookingDto>(BookingJsonData);
                Booking.Status = "Approved";
                BookingJsonData = JsonConvert.SerializeObject(Booking);
                StringContent stringContent = new StringContent(BookingJsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("http://localhost:5250/api/Booking", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            else { return View(); }




        }

    }
}
