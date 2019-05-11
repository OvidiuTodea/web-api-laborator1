using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator1.Models
{
    //DbContext = unit of work sau o colectie de repositoriuri
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
        }

        // un DbSet este un repository si o tabela din baza de date
        public DbSet<Movie> Movies { get; set; }
    }
}
 
