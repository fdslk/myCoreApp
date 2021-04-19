using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FilterApiImplement
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var weatherForecasts = LinqSearchMethod.list
            //     .Where(s => s.TemperatureC == Decimal.One)
            //     .Select(s => $"the date is {s.Date}, and the temperature is {s.TemperatureC}, and there are some summary like '{s.Summary}'");
            // var dateTimes = (from s in LinqSearchMethod.list orderby s.TemperatureC descending select s)
            //     .Skip(1)
            //     .Take(2)
            //     .Select(s => s.Date);
            // foreach (var weatherForecast in weatherForecasts)
            // {
            //     Console.WriteLine(weatherForecast);
            // }
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine(GetUrlContentLength());

        }

        private static async void asyncHelloWorld()
        {
            await Task.Delay(100);
            Console.WriteLine("async Hello world");
        }

        public static async Task<int> GetUrlContentLength()
        {
            var httpClient = new HttpClient();
            Task<string> task = httpClient.GetStringAsync("https://docs.microsoft.com/dotnet");
            DoIndependencyWork();
            var contentString = await task;
            return contentString.Length;
        }

        private static void DoIndependencyWork()
        {
            Console.WriteLine("working ......");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://*:5000");
                });
    }
}
