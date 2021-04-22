using Day24.Models;
using Microsoft.EntityFrameworkCore;

namespace Day24.Data
{
    public class TourDbContext : DbContext
    {
        public TourDbContext(DbContextOptions<TourDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Tour> Tours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>().Property(x => x.Name).HasMaxLength(50);
        }
    }
}
