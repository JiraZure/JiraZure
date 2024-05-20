using Microsoft.AspNetCore.Mvc;

namespace JiraZure.Controllers
{
    [ApiController]
    //controller == ClassName
    [Route("[controller]")]
    public class WebhookAzure : ControllerBase
    {
        private readonly ILogger<WebhookAzure> _logger;

        public WebhookAzure(ILogger<WebhookAzure> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return 
        }
    }
}
