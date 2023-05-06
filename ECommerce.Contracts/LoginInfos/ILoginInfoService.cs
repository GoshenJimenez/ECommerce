using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.LoginInfos
{
    public interface ILoginInfoService : IService
    {
        List<LoginInfoDto>? GetByUser(Guid? userId);
        LoginInfoDto? Upsert(LoginInfoDto? loginInfo);
    }
}
