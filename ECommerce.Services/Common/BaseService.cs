using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Security.Claims;


namespace ECommerce.Services.Common
{

    public abstract class BaseService
    {
        protected readonly IMapper Mapper;
        protected readonly HttpContext? HttpContext;
        protected readonly IConfiguration Configuration;
        protected readonly ILogger<BaseService> Logger;

        public BaseService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            Configuration = configuration;
            Logger = logger;
            Mapper = mapper;
            HttpContext = httpContextAccessor.HttpContext;
        }


    }
}
