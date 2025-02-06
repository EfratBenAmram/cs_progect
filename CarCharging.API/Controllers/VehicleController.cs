
using CarCharging.Core.Model;
using CarCharging.Core.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web CarCharging for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdFit.CarCharging.Controllers
{
    [Route("CarCharging/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {


        private readonly IStop _pageService;
        public VehicleController(IStop pageService)
        {
            _pageService = pageService;
        }

        // GET: CarCharging/<PageController>
        [HttpGet]
        public List<Page> Get()
        {
            return _pageService.GetAll();
        }

        // GET CarCharging/<PageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST CarCharging/<PageController>
        [HttpPost]
        public Page Post([FromBody] Page page)
        {
            return _pageService.AddPage(page);
        }

        // PUT CarCharging/<PageController>/5
        [HttpPut("{id}")]
        public Page Put(int id, [FromBody] Page page)
        {
            return _pageService.UpdatePage(id, page);
        }

        // DELETE CarCharging/<PageController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _pageService.DeletePage(id);
        }
    }
}
