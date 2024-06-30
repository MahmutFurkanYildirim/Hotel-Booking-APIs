using AutoMapper;
using BookingProject.BusinessLayer.Abstract;
using BookingProject.DtoLayer.Dtos.RoomDto;
using BookingProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var roomList = _roomService.TGetList();
            return Ok(roomList);
        }

        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roomValues = _mapper.Map<Room>(roomAdd);
            _roomService.TInsert(roomValues);
            return Ok();

        }

        [HttpPut]
        public IActionResult UpdateRoom(RoomUpdateDto roomUpdate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updateRoomValues = _mapper.Map<Room>(roomUpdate);
            _roomService.TUpdate(updateRoomValues);
            return Ok();
        }
    }
}
