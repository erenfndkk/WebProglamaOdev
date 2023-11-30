using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliklinikController : ControllerBase
    {
        private readonly IPoliklinikService _poliklinikService;

        public PoliklinikController(IPoliklinikService poliklinikService)
        {
            _poliklinikService = poliklinikService;
        }

        [HttpGet]   
        public IActionResult PoliklinikList()
        {
            var values = _poliklinikService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddPoliklinik(Poliklinik poliklinik)
        {
            _poliklinikService.TInsert(poliklinik);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePoliklinik(int id)
        {
            var value = _poliklinikService.TGetByID(id);
            _poliklinikService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdatePoliklinik(Poliklinik poliklinik)
        {
            _poliklinikService.TUpdate(poliklinik);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetPoliklinik(int id)
        {
            var value = _poliklinikService.TGetByID(id);
            return Ok(value);
        }
    }
}
