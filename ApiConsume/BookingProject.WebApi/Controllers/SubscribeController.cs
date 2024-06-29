using BookingProject.BusinessLayer.Abstract;
using BookingProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult SubscribeList()
        {
            var Subscribes = _subscribeService.TGetList();
            return Ok(Subscribes);
        }

        [HttpPost]
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubscribe(int id)
        {
            var getSubscribeId = _subscribeService.TGetById(id);
            _subscribeService.TDelete(getSubscribeId);
            return Ok(ModelState);
        }

        [HttpPut]
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok(ModelState);
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribe(int id)
        {
            var getSubscribeId = _subscribeService.TGetById(id);
            return Ok(getSubscribeId);
        }
    }
}
