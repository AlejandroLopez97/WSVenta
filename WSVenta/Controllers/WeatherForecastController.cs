using Microsoft.AspNetCore.Mvc;

namespace WSVenta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            List<WeatherForecast> lst = new List<WeatherForecast>();
            lst.Add(new WeatherForecast() { Id = 5, Nombre = "Alejandro" });
            lst.Add(new WeatherForecast() { Id = 6, Nombre = "Daniela" });
            lst.Add(new WeatherForecast() { Id = 2, Nombre = "Alaska" });
            return lst;
        }
    }
}