using APIExample.Interfaces;
using APIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIExample.Services;

public class WeatherForcastServiceImpl : IWeatherForcastService
{
    private readonly string[] summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public List<WeatherForecast> GetWeatherForcast()
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                       new WeatherForecast
                       (
                           DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                           Random.Shared.Next(-20, 55),
                           summaries[Random.Shared.Next(summaries.Length)]
                       ))
                       .ToList();
        return forecast;
    }
}
