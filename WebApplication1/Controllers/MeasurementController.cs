using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeasurementController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            return Ok("Hello world!");
        }


    }
}
