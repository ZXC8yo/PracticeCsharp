using System;
using WeatherLibrary;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherForecast weatherForecast = new WeatherForecast();
            string location = "Санкт-Петербурге";
            string weather = weatherForecast.GetRandomWeather(location);
            Console.WriteLine(weather);
        }
    }
}