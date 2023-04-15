using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.Cars
{
    public class CarDto
    {
        public Guid? Id { get; set; }
        public string? Make { get; set; }
        public string? Manufacturer { get; set; }
        public int? Year { get; set; }
    }
}
