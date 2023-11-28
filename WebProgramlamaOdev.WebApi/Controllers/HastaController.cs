using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HastaController : ControllerBase
    {
        private readonly IHastaService _hastaService;

        public HastaController(IHastaService hastaService)
        {
            _hastaService = hastaService;
        }

        [HttpGet]
        public IActionResult HastaList()
        {
            var values = _hastaService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddHasta(Hasta hasta)
        {
            _hastaService.TInsert(hasta);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteHasta(int id)
        {
            var value = _hastaService.TGetByID(id);
            _hastaService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateHasta(Hasta hasta)
        {
            _hastaService.TUpdate(hasta);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetHasta(int id)
        {
            var value = _hastaService.TGetByID(id);
            return Ok(value);
        }
    }
}
