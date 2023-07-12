using Microsoft.AspNetCore.Components;
using SingeltonPatternTest.Logger;

namespace SingeltonPatternTest
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public WeatherForecast(long logIndex)
        {
            Console.WriteLine($"{logIndex}. Weather Forecase Instance Created");
        }
    }
}