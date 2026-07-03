using System;

namespace WeatherStation
{
    public class MobileDisplay : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine($"Mobile Display : Temperature = {temperature}°C");
        }
    }
}