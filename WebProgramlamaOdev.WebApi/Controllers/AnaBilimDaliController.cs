using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnaBilimDaliController : ControllerBase
    {
        private readonly IAnaBilimDaliService _anaBilimDaliService;

        public AnaBilimDaliController(IAnaBilimDaliService anaBilimDaliService)
        {
            _anaBilimDaliService = anaBilimDaliService;
        }

        [HttpGet]
        public IActionResult AnaBilimDaliList()
        {
            var values = _anaBilimDaliService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAnaBilimDali(AnaBilimDali anaBilimDali)
        {
            _anaBilimDaliService.TInsert(anaBilimDali);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAnaBilimDali(int id)
        {
            var value = _anaBilimDaliService.TGetByID(id);
            _anaBilimDaliService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAnaBilimDali(AnaBilimDali anaBilimDali)
        {
            _anaBilimDaliService.TUpdate(anaBilimDali);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAnaBilimDali(int id)
        {   
            var value = _anaBilimDaliService.TGetByID(id);
            return Ok(value);
        }
    }
}
