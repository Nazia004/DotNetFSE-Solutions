namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();

            MobileDisplay mobile = new MobileDisplay();
            TVDisplay tv = new TVDisplay();

            station.RegisterObserver(mobile);
            station.RegisterObserver(tv);

            station.SetTemperature(30);

            System.Console.WriteLine();

            station.SetTemperature(35);
        }
    }
}
