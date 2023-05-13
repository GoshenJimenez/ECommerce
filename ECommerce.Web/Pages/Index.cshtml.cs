using ECommerce.Contracts.Users;
using ECommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.WebSockets;

namespace ECommerce.Web.Pages
{
    [Authorize]
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly IUserService _userService;
        public Index(ILogger<Index> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public void OnGet()
        {
            
           this.Users =  _userService.GetAll();

        }

        public List<UserDto> Users { get; set; }
    }
}