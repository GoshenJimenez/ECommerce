using ECommerce.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Models
{
    public class LoginInfo : BaseModel
    {
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public LoginType? LoginType { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
    }
}
