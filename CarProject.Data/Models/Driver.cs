using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Data.Models
{
    public class Driver
    {
        [Key]
        public int DriverId { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Location { get; set; }
        public ICollection<Automobile> Vehicles { get; set; }
        public ICollection<Driver> Friends { get; set; }
        public Team Team { get; set; }
    }
}
