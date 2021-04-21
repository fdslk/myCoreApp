using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilterApiImplement.Configuration;
using FilterApiImplement.Filter;
using FilterApiImplement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using StackExchange.Redis;

namespace FilterApiImplement.Controllers
{
    [ApiController]
    [Route("/weather")]
    public class WeatherForecastController : ControllerBase
    {
        private IWeatherSerive _weatherSerive;
        private IConfiguration _configuration;
        private EmailConfigure _emailConfigure;
        
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
            IWeatherSerive weatherSerive, 
            IConfiguration configuration, IOptionsMonitor<EmailConfigure> optionsMonitor)
        {
            _logger = logger;
            _weatherSerive = weatherSerive;
            _configuration = configuration;
            _emailConfigure = optionsMonitor.CurrentValue;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            var weatherDays = _weatherSerive.GetWeatherDays();
            
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet("getValue")]
        //[ServiceFilter(typeof(AsyncActionFilterExample))]
        // [ServiceFilter(typeof(ActionFilterExample))]
        // [AddHeader("Author", "Rick Anderson", Order = 2)]
        // [ServiceFilter(typeof(MyActionFilterAttribute), Order = 2)]
        // [ServiceFilter(typeof(MyActionFilterAttribute2), Order = 1)]
        [TypeFilter(typeof(AsyncActionFilterExample))]
        //typefilter vs serviceFilter
        async public Task<string> GetWeatherServiceConfig()
        {
            var emailConfigurePassword = _emailConfigure.Password;
            var emailConfigureUsername = _emailConfigure.Username;
            var value = _configuration.GetValue<int>("Logging:LogLevel:Test");
            return value.ToString();
        }

        [HttpGet("getString")]
        async public Task<string> GetSelfIncreaseNumber([FromQuery] string redisKey, string redisValue)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("redis:6379");
            IDatabase database = redis.GetDatabase();
            database.StringSet(redisKey, redisValue);
            var stringGet = database.StringGet(redisKey);
            return stringGet;
        }
    }
}
