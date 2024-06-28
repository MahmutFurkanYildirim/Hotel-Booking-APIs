using BookingProject.BusinessLayer.Abstract;
using BookingProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StaffController : ControllerBase
	{
		private readonly IStaffService _staffService;

		public StaffController(IStaffService staffService)
		{
			_staffService = staffService;
		}

		[HttpGet]
		public IActionResult StaffList()
		{
			var staffs = _staffService.TGetList();
			return Ok(staffs);
		}

		[HttpPost]
		public IActionResult AddStaff(Staff staff)
		{
			_staffService.TInsert(staff);	
			return Ok(ModelState);
		}

		[HttpDelete]
		public IActionResult DeleteStaff(int id)
		{
			var deleteStaff = _staffService.TGetById(id);
			_staffService.TDelete(deleteStaff);
			return Ok(ModelState);
		}

		[HttpPut]
		public IActionResult UpdateStaff(Staff staff)
		{
			_staffService.TUpdate(staff);
			return Ok(ModelState);
		}

		[HttpGet("{id}")]
		public IActionResult GetStaff(int id)
		{
			var staffValue = _staffService.TGetById(id);
			return Ok(staffValue);
		}
	}
}
