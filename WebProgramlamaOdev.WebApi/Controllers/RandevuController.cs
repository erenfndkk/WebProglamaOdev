using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandevuController : ControllerBase
    {
        private readonly IRandevuService _randevuService;

        public RandevuController(IRandevuService randevuService)
        {
            _randevuService = randevuService;
        }

        [HttpGet]
        public IActionResult RandevuList()
        {
            var values = _randevuService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRandevu(Randevu randevu)
        {
            _randevuService.TInsert(randevu);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRandevu(int id)
        {
            var value = _randevuService.TGetByID(id);
            _randevuService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRandevu(Randevu randevu)
        {
            _randevuService.TUpdate(randevu);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRandevu(int id)
        {
            var value = _randevuService.TGetByID(id);
            return Ok(value);
        }
    }
}
