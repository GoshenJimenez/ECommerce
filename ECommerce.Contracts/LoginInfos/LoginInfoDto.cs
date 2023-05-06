using ECommerce.Data.Enums;
using ECommerce.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.LoginInfos
{
    public class LoginInfoDto
    {
        public Guid? Id { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public LoginType? LoginType { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
    }
}
