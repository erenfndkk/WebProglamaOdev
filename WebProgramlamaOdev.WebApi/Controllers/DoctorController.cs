using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public IActionResult DoctorList()
        {
            var values = _doctorService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {
            _doctorService.TInsert(doctor);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteDoctor(int id)
        {
            var value = _doctorService.TGetByID(id);
            _doctorService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDoctor(Doctor doctor)
        {
            _doctorService.TUpdate(doctor);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            var value = _doctorService.TGetByID(id);
            return Ok(value);
        }
    }
}
