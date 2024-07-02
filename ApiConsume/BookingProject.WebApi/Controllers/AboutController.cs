using BookingProject.BusinessLayer.Abstract;
using BookingProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var Abouts = _aboutService.TGetList();
            return Ok(Abouts);
        }

        [HttpPost]
        public IActionResult AddAbout(About about)
        {
            _aboutService.TInsert(about);
            return Ok(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var deleteAboutId = _aboutService.TGetById(id);
            _aboutService.TDelete(deleteAboutId);
            return Ok(ModelState);
        }

        [HttpPut]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return Ok(ModelState);
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var AboutValue = _aboutService.TGetById(id);
            return Ok(AboutValue);
        }
    }
}
