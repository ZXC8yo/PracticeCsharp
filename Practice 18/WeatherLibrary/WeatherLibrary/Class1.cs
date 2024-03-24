using System;

namespace WeatherLibrary
{
    public class WeatherForecast
    {
        private static  string[] WeatherConditions = { "Солнечно", "Облачно", "Дождливо", "Гроза" };

        public string GetRandomWeather(string location)
        {
            Random random = new Random();
            string randomWeatherCondition = WeatherConditions[random.Next(WeatherConditions.Length)];
            return $"Погода в {location} — {randomWeatherCondition}.";
        }
    }
}