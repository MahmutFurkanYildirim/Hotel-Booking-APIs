using BookingProject.BusinessLayer.Abstract;
using BookingProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RoomController : ControllerBase
	{
		private readonly IRoomService _roomService;

		public RoomController(IRoomService roomService)
		{
			_roomService = roomService;
		}

		[HttpGet]
		public IActionResult RoomList()
		{
			var rooms = _roomService.TGetList();
			return Ok(rooms);
		}
		
		[HttpPost]
		public IActionResult AddRoom(Room room)
		{
			_roomService.TInsert(room);
			return Ok(ModelState);
		}

		[HttpDelete]
		public IActionResult DeleteRoom(int id)
		{
			var deleteRoomId = _roomService.TGetById(id);
			_roomService.TDelete(deleteRoomId);
			return Ok(ModelState);
		}

		[HttpPut]
		public IActionResult UpdateRoom(Room room)
		{
			_roomService.TUpdate(room);
			return Ok(ModelState);
		}

		[HttpGet("{id}")]
		public IActionResult GetRoom(int id)
		{
			var roomValue = _roomService.TGetById(id);
			return Ok(roomValue);
		}

	}
}
