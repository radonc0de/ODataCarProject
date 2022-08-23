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

            var ryosukeFC = new Automobile()
            {
                Year = 1990,
                Make = "Mazda",
                Model = "RX-7",
                OtherNames = new List<string>() { "SAVANNA RX-7 III" }
            };

            // Driver

            var iketani = new Driver()
            {
                FirstName = "Koichiro",
                LastName = "Iketani",
                Location = "Gunma Prefecture",
                Vehicles = new List<Automobile>() { iketaniS13 },
            };


            var ryosuke = new Driver()
            {
                FirstName = "Ryosuke",
                LastName = "Takahashi",
                Location = "Takasaki, Gunma Prefecture",
                Vehicles = new List<Automobile>() { ryosukeFC }

            };

            // Team

            var speedStars = new Team()
            {
                Name = "Akina Speed Stars",
                Members = new List<Driver>() { iketani },
            };

            var projectD = new Team()
            {
                Name = "ProjectD",
                Members = new List<Driver>() { ryosuke }
            };

            ryosukeFC.Driver = ryosuke;
            iketaniS13.Driver = iketani;
            ryosuke.Team = projectD;
            iketani.Team = speedStars;
            context.Automobile.Add(iketaniS13);
            context.Automobile.Add(ryosukeFC);
            context.Driver.Add(iketani);
            context.Driver.Add(ryosuke);
            context.Team.Add(speedStars);
            context.Team.Add(projectD);



        }
    }
}
