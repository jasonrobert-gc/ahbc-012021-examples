using CapstoneApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace CapstoneMvc.Services
{
    public class CarsService : ICarsService
    {
        private readonly HttpClient _client;

        public CarsService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Car>> Search(SearchCarRequest request)
        {
            return await _client.GetFromJsonAsync<IEnumerable<Car>>($"api/Cars/search?make={request.Make}&model={request.Model}&year={request.Year}");
        }
    }
}
