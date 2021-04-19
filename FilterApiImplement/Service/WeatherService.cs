using System.Collections.Generic;
using System.Threading.Tasks;

namespace FilterApiImplement.Service
{
    public class WeatherService:IWeatherSerive
    {
        async public Task<List<int>> GetWeatherDays()
        {
            List<int> testList = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                testList.Add(i);
            }

            return testList;
        }
    }

    public interface IWeatherSerive
    {
        public Task<List<int>> GetWeatherDays();
    }
}