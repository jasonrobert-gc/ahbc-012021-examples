using Day23.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Day23.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
