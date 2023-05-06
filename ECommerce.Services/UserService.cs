using AutoMapper;
using ECommerce.Contracts;
using ECommerce.Contracts.Users;
using ECommerce.Data.Models;
using ECommerce.Services.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace ECommerce.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IRepository<User> _userRepository;
        public UserService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper, IHttpContextAccessor httpContextAccessor,
              IRepository<User> userRepository
            )
            : base(configuration, logger, mapper, httpContextAccessor)
        {
            _userRepository = userRepository;
        }

        public List<UserDto>? GetAll()
        {
            var entities = _userRepository.All();

            if (entities == null)
                return null;

            return Mapper.Map<List<UserDto>>(entities);
        }

        public UserDto? GetByEmail(string? emailAddress = null)
        {
            if (!string.IsNullOrEmpty(emailAddress))
            {
                var entity = _userRepository.All().FirstOrDefault(a => a.EmailAddress != null &&  a.EmailAddress!.ToLower() == emailAddress!.ToLower());

                if (entity == null)
                    return null;

                return Mapper.Map<UserDto>(entity);
            }

            return null;
        }
    }
}
