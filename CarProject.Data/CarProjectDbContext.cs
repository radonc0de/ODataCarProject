using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CarProject.Data.Models;

namespace CarProject.Data
{
    public class CarProjectDbContext : DbContext
    { 
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Automobile> Automobile { get; set; }
        public DbSet<Team> Team { get; set; }

        public CarProjectDbContext()
        {
            Database.SetInitializer(new CarProjectDbInitializer());
            // disable lazy loading
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().HasMany(m => m.Vehicles).WithMany();
            modelBuilder.Entity<Driver>().HasMany(f => f.Friends).WithMany();

        }

    }
}
