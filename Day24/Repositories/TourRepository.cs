using Day24.Data;
using Day24.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day24.Repositories
{
    public class TourRepository : ITourRepository
    {
        private readonly TourDbContext _context;

        public TourRepository(TourDbContext context)
        {
            _context = context;
        }

        public async Task Create(Tour movie)
        {
            _context.Tours.Add(movie);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Tour>> Get()
        {
            return await _context.Tours.ToListAsync();
        }

        public async Task<Tour> Get(int id)
        {
            return await _context.Tours.FindAsync(id);
        }

        public Task Update(Tour movie)
        {
            throw new NotImplementedException();
        }
    }
}
