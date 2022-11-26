using Microsoft.AspNetCore.Mvc;
using YourDynastySite.Services;
using Models.Models;
using Models.Keys;

namespace Forum.Areas.User
{
    public class LoginController : Controller
    {
        private readonly AuthorizationService _authorizationService;
        private readonly WowPersonParsers.WowPersonParser _wowPersonParser;

        public LoginController(
            AuthorizationService authorizationService,
            WowPersonParsers.WowPersonParser wowPersonParse)
        {
            _wowPersonParser = wowPersonParse;
            _authorizationService = authorizationService;
        }

        [HttpGet("login")]
        public async Task<IActionResult> Index(string? redirect)
        {
            return View((object?)redirect);
        }

        [HttpGet("exit")]
        public IActionResult Exit()
        {
            Response.Cookies.Delete(AuthentificationKeys.UserAuthTokenKey);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            var token = String.Empty;
            try
            {
                token = await _authorizationService.LoginAsync(loginRequest);
            }
            catch { };
            if (String.IsNullOrEmpty(token))
            {
                return RedirectToAction("Index", "Login");
            }
            Response.Cookies.Append(AuthentificationKeys.UserAuthTokenKey, token);
            if (!String.IsNullOrEmpty(loginRequest.Redirect))
            {
                return Redirect(loginRequest.Redirect);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
