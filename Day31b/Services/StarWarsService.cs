using Day31b.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Day31b.Services
{
    public class StarWarsService : IStarWarsService
    {
        private readonly HttpClient _client;

        public StarWarsService(HttpClient client)
        {
            _client = client;
        }

        public async Task<PersonCollection> GetPeopleAsync()
        {
            return await _client.GetFromJsonAsync<PersonCollection>("people/");
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            return await _client.GetFromJsonAsync<Person>($"people/{id}");
        }
    }
}
