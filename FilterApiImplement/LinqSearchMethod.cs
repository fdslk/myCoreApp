using System;
using System.Collections.Generic;

namespace FilterApiImplement
{
    public class LinqSearchMethod
    {
        public static List<WeatherForecast> list = new List<WeatherForecast>()
        {
            new WeatherForecast(){Date = new DateTime().AddDays(1), TemperatureC =  1, Summary =
                $"{new DateTime().AddDays(1).ToString()}"
            },
            new WeatherForecast(){Date = new DateTime().AddDays(2), TemperatureC =  2, Summary =
                $"{new DateTime().AddDays(2).ToString()}"
            },
            new WeatherForecast(){Date = new DateTime().AddDays(3), TemperatureC =  3, Summary =
                $"{new DateTime().AddDays(3).ToString()}"
            },
            new WeatherForecast(){Date = new DateTime().AddDays(4), TemperatureC =  4, Summary =
                $"{new DateTime().AddDays(4).ToString()}"
            },
            new WeatherForecast(){Date = new DateTime().AddDays(5), TemperatureC =  5, Summary =
                $"{new DateTime().AddDays(5).ToString()}"
            },
        };
    }
}