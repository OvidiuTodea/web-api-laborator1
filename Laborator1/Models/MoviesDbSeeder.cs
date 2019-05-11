using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator1.Models
{
    public static class MoviesDbSeeder
    {
        public static void Initialize(MoviesDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any flowers.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            context.Movies.AddRange(
                new Movie
                {
                    Title = "Black Mirror",
                    Runtime = 100,
                    Rating = 2.2,
                    Storyline = "interesting"

                },
                new Movie
                {
                    Title = "Black Mirror 2",
                    Runtime = 90,
                    Rating = 1.2,
                    Storyline = "suspans"
                }
            );
            context.SaveChanges();  // commit transaction
        }
    }
}
