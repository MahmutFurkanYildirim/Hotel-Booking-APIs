using BookingProject.BusinessLayer.Abstract;
using BookingProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookinController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookinController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var Services = _bookingService.TGetList();
            return Ok(Services);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var deleteService = _bookingService.TGetById(id);
            _bookingService.TDelete(deleteService);
            return Ok(ModelState);
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok(ModelState);
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var ServiceValue = _bookingService.TGetById(id);
            return Ok(ServiceValue);
        }
    }
}
