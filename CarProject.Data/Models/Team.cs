using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Data.Models
{
    public class Team 
    { 
        [Key]
        public int TeamId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public Driver Leader { get; set; }
    }
}
