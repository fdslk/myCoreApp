using Microsoft.Extensions.DependencyInjection;
using SRPTEST.SRPModel;
using Newtonsoft.Json;

namespace SRPTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddScoped<IShapeAreaCalculator, CircleAreaCalculator>();
            services.AddScoped<IShapeAreaCalculator, SquareAreaCalculator>();
            services.AddScoped<IAreaCalculator, SRPTEST.SRPModel.AreaCalculator>();
            var serviceProvider = services.BuildServiceProvider();
            var areaCalculator = serviceProvider.GetService<IAreaCalculator>();
            var result = areaCalculator.CalculateBreakDown(new Shape(){
                ShapeType = typeof(CircleAreaCalculator).Name,
                Radius = 2
            });
            System.Console.WriteLine(JsonConvert.SerializeObject(result));
        }
    }
}
