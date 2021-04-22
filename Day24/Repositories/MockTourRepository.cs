using Day24.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Day24.Repositories
{
    public class MockTourRepository : ITourRepository
    {
        public Task Create(Tour movie)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tour>> Get()
        {
            return Task.FromResult(new List<Tour>
            {
                new Tour
                {
                    Id = 56,
                    Name = "Rage Against the Machine",
                    Date = DateTime.Parse("5/22/2022"),
                    Location = "Little Ceasars Arena",
                    Price = 125.00
                }
            });
        }

        public Task<Tour> Get(int id)
        {
            return Task.FromResult(
                new Tour
                {
                    Id = 56,
                    Name = "Rage Against the Machine",
                    Date = DateTime.Parse("5/22/2022"),
                    Location = "Little Ceasars Arena",
                    Price = 125.00
                });
        }

        public Task Update(Tour movie)
        {
            throw new NotImplementedException();
        }
    }
}
