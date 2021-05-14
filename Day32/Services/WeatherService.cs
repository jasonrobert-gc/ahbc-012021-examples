using Day32.Services.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Day32.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly HttpClient _client;

        public WeatherService(HttpClient client)
        {
            _client = client;
        }

        public async Task<LocationResult> GetLocationAsync(double longitude, double latitude)
        {
            return await _client.GetFromJsonAsync<LocationResult>($"points/{latitude},{longitude}");
        }

        public async Task<ForecastResult> GetForecastAsync(string gridId, int gridX, int gridY)
        {
            return await _client.GetFromJsonAsync<ForecastResult>($"gridpoints/{gridId}/{gridX},{gridY}/forecast");
        }
    }
}
