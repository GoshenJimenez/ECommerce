using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public Guid? Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? CreatedByUserId { get; set; }

        [ForeignKey("CreatedByUserId")]
        public User? CreatedByUser { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedUserId { get; set; }

        [ForeignKey("UpdatedUserId")]
        public User? UpdatedByUser { get; set; }
    }
}
