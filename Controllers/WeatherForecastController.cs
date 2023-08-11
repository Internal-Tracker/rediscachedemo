using Microsoft.AspNetCore.Mvc;

namespace rediscachedemoazure.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            int res =0;
            int div = 0;

            int num = 5;
            //try
            //{
              res =  num / div;
               

            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError(ex.Message.ToString(), ex);
            //}
            //finally
            //{
            //    _logger.LogInformation("finally block");
            //}
            return Ok(res);
        }
    }
}