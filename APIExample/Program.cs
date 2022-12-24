using APIExample.Interfaces;
using APIExample.Models;
using APIExample.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IWeatherForcastService, WeatherForcastServiceImpl>();
builder.Services.AddSingleton<IRequestValidationService, RequestValidationServiceImpl>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();


app.MapGet("/weatherforecast", ([FromServices] IWeatherForcastService weatherForcastService) =>
{
    return weatherForcastService.GetWeatherForcast();
});

app.MapPost("/validateRequest", ([FromServices] IRequestValidationService requestValidationService, [FromBody] BodyObject body) =>
{
    var validationResult = requestValidationService.IsBodyValid(body);
    if (!validationResult.IsValid)
    {
        return Results.BadRequest(validationResult.Message);
    }

    return Results.Ok();
});

app.Run();
