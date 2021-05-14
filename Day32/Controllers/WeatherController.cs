using Day32.Models;
using Day32.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day32.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _service;

        public WeatherController(IWeatherService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(LocationViewModel model)
        {
            var location = await _service.GetLocationAsync(model.Longitude, model.Latitude);
            var forcasts = await _service.GetForecastAsync(location.properties.gridId, location.properties.gridX, location.properties.gridY);
            var response = forcasts.properties.periods.Select(x => 
                new ForecastViewModel(
                    x.name, 
                    $"{x.temperature} {x.temperatureUnit}", 
                    x.windSpeed, 
                    x.shortForecast));
            return View(response);
        }
    }
}
