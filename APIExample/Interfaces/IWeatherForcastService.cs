using APIExample.Models;
using System.Collections.Generic;

namespace APIExample.Interfaces;

public interface IWeatherForcastService
{
    List<WeatherForecast> GetWeatherForcast();
}
