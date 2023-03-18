using ECommerce.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Helpers
{
    public static class StringHelpers
    {
        public static string? ForCompare(this LoginStatus? loginStatus)
        {
            if (loginStatus == null)
            {
                return "";
            }

            return loginStatus.ToString()!.ToLower();
        }
    }
}
