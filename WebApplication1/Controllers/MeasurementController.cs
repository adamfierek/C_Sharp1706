using Microsoft.AspNetCore.Mvc;
using TestApp.Models;
using TestApp.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeasurementController : ControllerBase
    {
        private MeasurementService _service;

        public MeasurementController(MeasurementService service)
        {
            _service = service;
        }

        [HttpGet("info")]
        public IActionResult GetInfo()
        {
            return Ok("Hello world!");
        }


        [HttpGet]
        public async Task<IActionResult> GetMeasurementsAsync()
        {
            var measurements = await _service.GetMeasurements(10);
            return Ok(measurements);
        }

        [HttpPost]
        public IActionResult AddMeasurement([FromBody] Measurement measurement) //optional attribute
        {
            if (measurement.Time > DateTime.Now)
                return BadRequest();
            //save to db

            return NoContent();
        }

        [HttpGet("add/{a:int}/{b:int}")]
        public IActionResult AddAB([FromRoute] int a, [FromRoute] int b) //optional attribute
        {
            return Ok(a + b);
        }

        [HttpGet("add")]
        public IActionResult AddABFromQuery([FromQuery] int a, [FromQuery] int b)
        {
            return Ok(a + b);
        }

        [HttpGet("addheader")]
        public IActionResult AddABFromHeader([FromHeader] int a, [FromHeader] int b)
        {
            return Ok(a + b);
        }
    }
}
