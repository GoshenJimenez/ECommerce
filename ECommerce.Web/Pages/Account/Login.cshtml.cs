using ECommerce.Contracts.Cars;
using ECommerce.Contracts.LoginInfos;
using ECommerce.Contracts.Users;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECommerce.Web.Pages.Account
{
    public class Login : PageModel
    {
        private readonly ILogger<Login> _logger;
        private readonly IUserService _userService;
        private readonly ILoginInfoService _loginInfoService;

        [BindProperty]
        public string? EmailAddress { get; set; }
        [BindProperty]
        public string? Password { get; set; }

        public Login(ILogger<Login> logger, IUserService userService, ILoginInfoService loginInfoService)
        {
            _logger = logger;
            _userService = userService;
            _loginInfoService = loginInfoService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var user = _userService.GetByEmail(EmailAddress);

            if(user != null)
            {
                var loginInfos = _loginInfoService.GetByUser(user.Id);

                if (loginInfos != null)
                {
                    var passwordInfo = loginInfos!.FirstOrDefault(a => a.Key != null && a.Key.ToLower() == "password");
                    var loginRetriesInfo = loginInfos!.FirstOrDefault(a => a.Key != null && a.Key.ToLower() == "loginretries");
                    var accountStatusInfo = loginInfos!.FirstOrDefault(a => a.Key != null && a.Key.ToLower() == "accountstatus");

                    if (passwordInfo != null)
                    {
                        var encPassword = BCrypt.Net.BCrypt.HashPassword(Password);
                        if(passwordInfo.Value != encPassword)
                        {
                            if(loginRetriesInfo != null)
                            {
                                var loginRetries = (int.Parse(loginRetriesInfo.Value != null ? loginRetriesInfo.Value : "0") + 1);
                                loginRetriesInfo.Value = loginRetries.ToString();

                                _loginInfoService.Upsert(loginRetriesInfo);
                                
                                if (loginRetries > 2)
                                {
                                    if(accountStatusInfo!= null)
                                    {
                                        accountStatusInfo.Value = "LockedOut";

                                        _loginInfoService.Upsert(accountStatusInfo);
                                    }
                                }
                            }
                            else
                            {
                                if (accountStatusInfo != null)
                                {
                                    if(accountStatusInfo.Value != null && accountStatusInfo.Value.ToLower() != "active")
                                    {
                                        ModelState.AddModelError("", "Account is Inactive");
                                    }
                                    else
                                    {
                                        if (loginRetriesInfo != null)
                                        {
                                            loginRetriesInfo.Value = "0";
                                            _loginInfoService.Upsert(loginRetriesInfo);
                                        }

                                        SignIn();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return Page();
        }

        public void SignIn()
        {

        }

    }
}
