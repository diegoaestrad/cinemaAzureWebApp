using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cinemaAzureWebApp.Models
{
    public class CinemaContext : DbContext  
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options) { }

        public DbSet<Cinema> Cinema { get; set; }

    }
}
