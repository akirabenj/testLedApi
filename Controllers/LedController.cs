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

        [HttpGet("{state?}")]
        public IActionResult Get(bool state)
        {
            var toggleLED = new ToggleLED();
            toggleLED.SwitchLED(state);
            return Ok(1);
        }
    }
}
