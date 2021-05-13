using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Lab27.Services.Models;

namespace Lab27.Services
{
    public class RedditService : IRedditService
    {
        private readonly HttpClient _client;

        public RedditService(HttpClient client)
        {
            _client = client;
        }

        public async Task<RedditResponse> QuerySubredditAsync(string name)
        {
            return await _client.GetFromJsonAsync<RedditResponse>($"{name}/.json");
        }
    }
}
