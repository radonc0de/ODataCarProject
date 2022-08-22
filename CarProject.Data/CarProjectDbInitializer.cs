using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CarProject.Data.Models;

namespace CarProject.Data
{
    public class CarProjectDbInitializer : DropCreateDatabaseAlways<CarProjectDbContext>
    {
        protected override void Seed(CarProjectDbContext context)
        {
            // Vehicle
            var iketaniS13 = new Automobile()
            {
                Year = 1988,
                Make = "Nissan",
                Model = "S13"
            };

            // Driver

            var iketani = new Driver()
            {
                FirstName = "Koichiro",
                LastName = "Iketani",
                Location = "Gunma Prefecture",
                Vehicles = new List<Automobile>() { iketaniS13 }
            };

            // Team

            var speedStars = new Team()
            {
                Name = "Akina Speed Stars",
                Leader = iketani
            };
        }
    }
}
