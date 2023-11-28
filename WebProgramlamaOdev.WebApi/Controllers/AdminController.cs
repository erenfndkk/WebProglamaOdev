using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public IActionResult AdminList()
        {
            var values = _adminService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminService.TInsert(admin);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAdmin(int id)
        {
            var value = _adminService.TGetByID(id);
            _adminService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAdmin(Admin admin)
        {
            _adminService.TUpdate(admin);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAdmin(int id)
        {
            var value = _adminService.TGetByID(id);
            return Ok(value);
        }
    }
}
