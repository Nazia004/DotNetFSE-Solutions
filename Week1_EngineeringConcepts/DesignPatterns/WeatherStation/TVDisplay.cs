using System;

namespace WeatherStation
{
    public class TVDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"TV Display : Temperature = {temperature}°C");
        }
    }
}