using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Data.Models
{
    public class CustomAutomobile : Automobile
    {
        public ICollection<string> Customizations { get; set; }
    }
}
