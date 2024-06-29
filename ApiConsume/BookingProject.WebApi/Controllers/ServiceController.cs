﻿using BookingProject.BusinessLayer.Abstract;
using BookingProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var Services = _serviceService.TGetList();
            return Ok(Services);
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TInsert(service);
            return Ok(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var deleteService = _serviceService.TGetById(id);
            _serviceService.TDelete(deleteService);
            return Ok(ModelState);
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok(ModelState);
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var ServiceValue = _serviceService.TGetById(id);
            return Ok(ServiceValue);
        }
    }
}
