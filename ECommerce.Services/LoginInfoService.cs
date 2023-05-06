using AutoMapper;
using ECommerce.Contracts;
using ECommerce.Contracts.LoginInfos;
using ECommerce.Contracts.Users;
using ECommerce.Data.Models;
using ECommerce.Data.Models.Others;
using ECommerce.Services.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace ECommerce.Services
{
    public class LoginInfoService : BaseService, ILoginInfoService
    {
        private readonly IRepository<LoginInfo> _loginInfoRepository;
        public LoginInfoService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper, IHttpContextAccessor httpContextAccessor,
              IRepository<LoginInfo> loginInfoRepository
            )
            : base(configuration, logger, mapper, httpContextAccessor)
        {
            _loginInfoRepository = loginInfoRepository;
        }

        public List<LoginInfoDto>? GetByUser(Guid? userId)
        {
            var entities = _loginInfoRepository.All().Where(a => a.UserId == userId);

            if (entities == null)
                return null;

            return Mapper.Map<List<LoginInfoDto>>(entities);
        }

        public LoginInfoDto? Upsert(LoginInfoDto? loginInfo)
        {
            if (loginInfo != null)
            {
                var entity = _loginInfoRepository.All().FirstOrDefault(a => a.Id == loginInfo.Id);

                if (entity != null)
                {
                    entity.Value = loginInfo.Value;
                    entity.UpdatedAt = DateTime.Now;
                    entity.UpdatedUserId = Guid.Parse("777eab55-31b1-494a-b804-078b8eaaa000");

                    _loginInfoRepository.Update(entity);


                }
                else
                {
                    entity = new LoginInfo()
                    {
                        Id = Guid.NewGuid(),
                        CreatedByUserId = Guid.Parse("777eab55-31b1-494a-b804-078b8eaaa000"),
                        UpdatedUserId = Guid.Parse("777eab55-31b1-494a-b804-078b8eaaa000"),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        LoginType = loginInfo.LoginType,
                        Key = loginInfo.Key,
                        Value = loginInfo.Value
                    };

                    _loginInfoRepository.AddAsync(entity);
                }

                _loginInfoRepository.SaveChangesAsync();
                return Mapper.Map<LoginInfoDto>(entity);
            }

            return null;
        }
    }
}
