using ExcepDomain;
using Microsoft.AspNetCore.Mvc;

namespace SuperException.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private  IWeatherService _WeatherService { get;}

    public WeatherForecastController( 
        IWeatherService WeatherService, ILogger<WeatherForecastController> logger)
    {
        _WeatherService = WeatherService;
        _logger = logger;
    }


    // [HttpGet(Name = "GetWeatherForecast")]
    // public ActionResult<IEnumerable<WeatherForecast>> Get(string cityName)
    // {
    //     try
    //     {
    //         if (cityName == "Chennai")
    //         {
    //             throw new Exception("No Weather Data For Chennai");
    //         }
    //         return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //         {
    //             Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
    //             TemperatureC = Random.Shared.Next(-20, 55),
    //             Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //         })
    //         .ToArray();

    //     }
    //     catch (Exception ex)
    //     {
    //         //return BadRequest(ex.Message);
    //         return NotFound(ex.Message);

    //     }
    // }

 [HttpGet(Name = "GetWeatherForecast")]
    public ActionResult<IEnumerable<WeatherForecast>> Get(string cityName)
    {
        return _WeatherService.Get(cityName).ToArray();
    }

}
