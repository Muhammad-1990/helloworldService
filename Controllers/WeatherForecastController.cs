using Microsoft.AspNetCore.Mvc;

namespace helloworldService.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };


    public WeatherForecastController()
    {
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        return "hello, " + Summaries[Random.Shared.Next(Summaries.Length)];
    }
}