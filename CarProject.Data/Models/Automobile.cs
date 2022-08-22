using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarProject.Data.Models
{
    public class Automobile
    { 
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(100)]
        public string Make { get; set; }
        [Required]
        [StringLength(100)]
        public string Model { get; set; }
        public ICollection<string> OtherNames { get; set; }

    
    }

}
