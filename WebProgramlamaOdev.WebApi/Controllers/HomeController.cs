using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public IActionResult HomeList()
        {
            var values = _homeService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddHome(Home home)
        {
            _homeService.TInsert(home);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteHome(int id)
        {
            var value = _homeService.TGetByID(id);
            _homeService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateHome(Home home)
        {
            _homeService.TUpdate(home);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetHome(int id)
        {
            var value = _homeService.TGetByID(id);
            return Ok(value);
        }
    }
}
