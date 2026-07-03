using System.Collections.Generic;

namespace WeatherStation
{
    public class WeatherStation : ISubject
    {
        private readonly List<IObserver> observers = new();
        private float temperature;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void SetTemperature(float temperature)
        {
            this.temperature = temperature;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
        }
    }
}