using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.Users
{
    public interface IUserService : IService
    {
        List<UserDto> GetAll();
    }
}
