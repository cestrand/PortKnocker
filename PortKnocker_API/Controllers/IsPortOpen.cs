using Microsoft.AspNetCore.Mvc;

namespace PortKnocker_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IsPortOpen : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public IsPortOpen(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "IsPortOpen")]
        public PortStatus Get(int portNumber)
        {
            return new PortStatus()
            {
                PortNumber = portNumber,
            };
        }
    }
}