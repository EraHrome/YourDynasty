using Microsoft.AspNetCore.Mvc;
using YourDynastySite.Services;
using Models.Models;
using YourDynastySite.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using YourDynastySite.Database.Entities;

namespace Forum.Areas.User
{
    public class RegistrationController : Controller
    {
        private readonly RegistrationService _registrationService;
        private readonly ApplicationContext _context;

        public RegistrationController(
            RegistrationService registrationService,
            ApplicationContext context)
        {
            _registrationService = registrationService;
            _context = context;
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
                if (await _registrationService.Register(request))
                {
                    var user = await _context.Users.FirstOrDefaultAsync(user => user.Email == request.Email);
                    if (user != null)
                    {
                        Guid personId = Guid.NewGuid();
                        user.PersonId = personId;
                        DynastyPerson person = new()
                        {
                            Id = personId,
                            Name = request.Login
                        };
                        await _context.DynastyPersons.AddAsync(person);
                        await _context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Registration", new { isNotSuccess = true });
            };
            return View("~/Views/Login/Index.cshtml");
        }
    }
}
