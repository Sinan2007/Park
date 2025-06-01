using Microsoft.EntityFrameworkCore;
using Park.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park.Data
{
    public class ParkDbContext:DbContext
    {
        public ParkDbContext() { }
        public DbSet<Facilities> Facilities { get; set; }
        public DbSet<PlantSpecies> PlantSpecies { get; set; }
        public DbSet<ZonePlants> ZonePlants { get; set; }
        public DbSet<Zones> Zones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=STUDENT9;Initial Catalog=Park;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
