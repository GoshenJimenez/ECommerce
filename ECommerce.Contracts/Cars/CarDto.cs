using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.Cars
{
    public class CarDto
    {
        public Guid? Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Make { get; set; }
        [Required]
        public string? Manufacturer { get; set; }
        [Required]
        public int? Year { get; set; }
    }
}
