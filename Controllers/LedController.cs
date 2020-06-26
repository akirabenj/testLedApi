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
        public IActionResult Get(int state)
        {
            var toggleLED = new ToggleLED();
            if (state == 1) {
                toggleLED.SwitchLED(true);
            } else if (state == 0) {
                toggleLED.SwitchLED(false);
            }
            
            return Ok(1);
        }
    }
}
