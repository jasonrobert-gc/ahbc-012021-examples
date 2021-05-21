using Assessment7Prep.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Assessment7Prep.Services
{
    public class DonutService : IDonutService
    {
        private readonly HttpClient _client;

        public DonutService(HttpClient client)
        {
            _client = client;
        }

        public async Task<DonutResults> GetAll()
        {
            return await _client.GetFromJsonAsync<DonutResults>("demo-apis/donuts.json");
        }

        public async Task<Donut> Get(int id)
        {
            return await _client.GetFromJsonAsync<Donut>($"demo-apis/donuts/{id}.json");
        }
    }
}
