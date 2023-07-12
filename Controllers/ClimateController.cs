using Microsoft.AspNetCore.Mvc;
using SingeltonPatternTest.Logger;

namespace SingeltonPatternTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClimateController : ControllerBase
    {
        private readonly NativeCustomLogger _customLogger;

        public ClimateController(NativeCustomLogger customLogger)
        {
            _customLogger = customLogger;
        }

        [HttpGet(Name = "create-climate-instance")]
        public IActionResult Get()
        {
            var check = new Climate(_customLogger.AssignLogIndex());
            return Ok();
        }
    }
}