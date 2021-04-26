using Day24.Models;
using System;
using System.Linq;

namespace Day24.Data
{
    public class DbInitializer
    {
        public static void Initialize(TourDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Tours.Any())
            {
                return;
            }

            context.Tours.AddRange(new[] {
                new Tour 
                {
                    Name = "Rage Against the Machine",
                    Date = DateTime.Parse("5/22/2022"),
                    Location = "Little Ceasar's Arena",
                    Price = 125
                },
                new Tour
                {
                    Name = "Machine Gun Kelly",
                    Date = DateTime.Parse("4/22/2022"),
                    Location = "Little Ceasar's Arena",
                    Price = 125
                },
                new Tour
                {
                    Name = "Grateful Dead",
                    Date = DateTime.Parse("1/22/2022"),
                    Location = "Little Ceasar's Arena",
                    Price = 125
                },
            });

            context.SaveChanges();
        }
    }
}
