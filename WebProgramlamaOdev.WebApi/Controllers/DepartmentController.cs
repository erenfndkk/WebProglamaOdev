using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult DepartmentList()
        {
            var values = _departmentService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            _departmentService.TInsert(department);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            var value = _departmentService.TGetByID(id);
            _departmentService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDepartment(Department department)
        {
            _departmentService.TUpdate(department);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetDepartment(int id)
        {
            var value = _departmentService.TGetByID(id);
            return Ok(value);
        }
    }
}
