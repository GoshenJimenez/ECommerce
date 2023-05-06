using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Data.Models;

namespace ECommerce.Contracts.LoginInfos
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<LoginInfo, LoginInfoDto>();
            CreateMap<LoginInfoDto, LoginInfo>();
        }
    }
}
