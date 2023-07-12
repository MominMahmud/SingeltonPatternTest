using Microsoft.AspNetCore.Mvc;
using SingeltonPatternTest.Logger;

namespace SingeltonPatternTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly NativeCustomLogger _customLogger;

        public WeatherForecastController (NativeCustomLogger customLogger)
        {
            _customLogger = customLogger;
        }

        [HttpGet(Name = "create-weather-forecast-instance")]
        public IActionResult Get()
        {
            var check = new WeatherForecast(_customLogger.AssignLogIndex());
            return Ok();
        }
    }
}