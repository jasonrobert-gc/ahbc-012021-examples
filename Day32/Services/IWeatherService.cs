using Day32.Services.Models;
using System.Threading.Tasks;

namespace Day32.Services
{
    public interface IWeatherService
    {
        Task<LocationResult> GetLocationAsync(double longitude, double latitude);
        Task<ForecastResult> GetForecastAsync(string gridId, int gridX, int gridY);
    }
}
