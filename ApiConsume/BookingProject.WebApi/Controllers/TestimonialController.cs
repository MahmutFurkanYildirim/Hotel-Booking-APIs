using BookingProject.BusinessLayer.Abstract;
using BookingProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}

		[HttpGet]
		public IActionResult TestimonialList()
		{
			var Testimonials = _testimonialService.TGetList();
			return Ok(Testimonials);
		}

		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			_testimonialService.TInsert(testimonial);
			return Ok(ModelState);
		}

		[HttpDelete]
		public IActionResult DeleteTestimonial(int id)
		{
			var deleteTestimonial = _testimonialService.TGetById(id);
			_testimonialService.TDelete(deleteTestimonial);
			return Ok(ModelState);
		}

		[HttpPut]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			_testimonialService.TUpdate(testimonial);
			return Ok(ModelState);
		}

		[HttpGet("{id}")]
		public IActionResult GetTestimonial(int id)
		{
			var TestimonialValue = _testimonialService.TGetById(id);
			return Ok(TestimonialValue);
		}
	}
}
