using System;
using System.Collections.Generic;
using System.Linq;
using Common;
using CustomResovler;
using CustomsResolvers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using models;
using Newtonsoft.Json;

namespace customSerialization.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public IActionResult CustomSerializeModel([FromBody] Student student){

            Student student1 = new Student{
                Id = 1,
                Name = "test",
                Grade = 2,
                Age = 12,
                AddressDetailStreet = "Xi'an"
            };

            System.Console.WriteLine(JsonConvert.SerializeObject(student1));

            string v = JsonHelper.ConvertJson.ConvertContentToJsonCamelCase(student1);

            return Ok(v);
        }

        [HttpGet("/ConvertToJSDatetime")]
        public IActionResult ConvertDatetimeToJSDatetime(){

            var order = DataHelper.GenerateOrder();

            System.Console.WriteLine(JsonConvert.SerializeObject(order));

            string result = JsonHelper.ConvertJson.ConvertContentUsingCustomContractResolver(order, new ConverterContractResolver());

            return Ok(result);
        }

        [HttpGet("/ShouldSerialize")]
        public IActionResult EqualObjectShouldSerialization(){
            Employee joe = new Employee();
            joe.Name = "Joe Employee";
            Employee mike = new Employee();
            mike.Name = "Mike Manager";

            joe.Manager = mike;
            mike.Manager = mike;
            
            string resultMike = JsonHelper.ConvertJson.ConvertContentUsingCustomContractResolver(mike, new ShouldSerializeContractResolver());
            string resultJeo = JsonHelper.ConvertJson.ConvertContentUsingCustomContractResolver(joe, new ShouldSerializeContractResolver());

            return Ok(resultMike + resultJeo);
        }
    }
}
