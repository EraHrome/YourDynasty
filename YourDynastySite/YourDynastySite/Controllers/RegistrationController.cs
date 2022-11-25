using Microsoft.AspNetCore.Mvc;
using YourDynastySite.Services;
using Models.Models;

namespace Forum.Areas.User
{
    public class RegistrationController : Controller
    {
        private readonly RegistrationService _registrationService;

        public RegistrationController(RegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpGet("registration")]
        public IActionResult Index(bool isNotSuccess = false)
        {
            return View(isNotSuccess);
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Registration(RegistrationRequest request)
        {
            try
            {
                await _registrationService.Register(request);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Registration", new { isNotSuccess = true });
            };
            return View("Home");
        }
    }
}
