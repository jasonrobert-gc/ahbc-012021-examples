using CapstoneApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CapstoneApi.Data
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}
