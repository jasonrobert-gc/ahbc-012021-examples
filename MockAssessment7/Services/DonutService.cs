using MockAssessment7.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MockAssessment7.Services
{
    public class DonutService : IDonutService
    {
        private readonly HttpClient _client;

        public DonutService(HttpClient client)
        {
            _client = client;
        }

        public async Task<Donut> Search(int id)
        {
            return await _client.GetFromJsonAsync<Donut>($"donuts/{id}.json");
        }
    }
}
