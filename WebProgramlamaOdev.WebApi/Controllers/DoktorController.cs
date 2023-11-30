using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoktorController : ControllerBase
    {
        private readonly IDoktorService _doktorService;

        public DoktorController(IDoktorService doktorService)
        {
            _doktorService = doktorService;
        }

        [HttpGet]
        public IActionResult DoktorList()
        {
            var values = _doktorService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddDoktor(Doktor doktor)
        {
            _doktorService.TInsert(doktor);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDoktor(int id)
        {
            var value = _doktorService.TGetByID(id);
            _doktorService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDoktor(Doktor doktor)
        {
            _doktorService.TUpdate(doktor);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetDoktor(int id)
        {
            var value = _doktorService.TGetByID(id);
            return Ok(value);
        }
    }
}
