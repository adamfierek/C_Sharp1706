﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApp.Models;
using TestApp.Services;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeasurementController : ControllerBase
    {
        private MeasurementService _service;
        private DatabaseContext _dbContext;

        public MeasurementController(MeasurementService service, DatabaseContext dbContext)
        {
            _service = service;
            _dbContext = dbContext;
        }

        [HttpGet("info")]
        public IActionResult GetInfo()
        {
            return Ok("Hello world!");
        }


        [HttpGet]
        public async Task<IActionResult> GetMeasurementsAsync()
        {
            var measurements = await _dbContext.Measurements.Where(m => m.Time > DateTime.Now.AddDays(-30)).ToListAsync();
            return Ok(measurements);
        }

        [HttpPost]
        public async Task<IActionResult> AddMeasurement([FromBody] Measurement measurement) //optional attribute
        {
            if (measurement.Time > DateTime.Now)
                return BadRequest();

            _dbContext.Measurements.Add(measurement);

            //additional db operations

            await _dbContext.SaveChangesAsync();

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
