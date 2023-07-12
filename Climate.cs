using Microsoft.AspNetCore.Components;
using SingeltonPatternTest.Logger;

namespace SingeltonPatternTest
{
    public class Climate
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public Climate(long logIndex)
        {
            Console.WriteLine($"{logIndex}. Cimate Instance Created");
        }
    }


}
