using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models.Others
{
    public class Car : BaseModel    
    {
        public string? Make { get; set; } 
        public string? Manufacturer { get; set; }
        public int? Year { get; set; }

    }
}
