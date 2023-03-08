using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExcepDomain.Exception;

namespace ExcepDomain
{
    public interface IWeatherService {
        IEnumerable<WeatherForecast> Get(string cityName);
    }
    public class WeatherService : IWeatherService
    {
        private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        public IEnumerable<WeatherForecast> Get(string cityName)
        {
           
            if (cityName == "Chennai")
            {
                //throw new DomaiNotFoundException("No Weather Data For Chennai");
                throw new ValidationException("No Weather Data For Chennai");

            }
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}