using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace testApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LedController : ControllerBase
    {
        private readonly ITemperatureService temperatureService;

        public LedController(ITemperatureService service)
        {
            temperatureService = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int state)
        {
            if (state == 1) {
                var temp = temperatureService.getCurrentTemperature();
                return Ok(temp);
            }
            
            return Ok(1);
        }
    }
}
