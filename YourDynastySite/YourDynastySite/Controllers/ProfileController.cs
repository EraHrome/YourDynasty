using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using YourDynastySite.Database.Contexts;
using YourDynastySite.Database.Entities;

namespace YourDynastySite.Controllers
{
    public class ProfileController : Controller
    {
        public ApplicationContext _context { get; set; }

        public ProfileController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> EditForm()
        {
            string uid = User.FindFirstValue(ClaimTypes.UserData);
            if(!int.TryParse(uid, out int userId))
            {
                return RedirectToAction("Index", "Home");
            }

            User user = await _context.Users.FirstAsync(user => user.Id == userId);
            DynastyPerson person = await _context.DynastyPersons.FirstAsync(p => p.Id == user.PersonId);

            if (person == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(person);
        }

        public async Task<IActionResult> UpdateProfile(DynastyPerson person)
        {
            if (person == null)
            {
                return RedirectToAction("Index", "Home");
            }

            DynastyPerson? dynastyPerson = await _context.DynastyPersons.FirstOrDefaultAsync(p => p.Id == p.Id);
            if (dynastyPerson == null)
            {
                return RedirectToAction("Index", "Home");
            }

            dynastyPerson.BirthPlace = person.BirthPlace;
            dynastyPerson.Gender = person.Gender;
            dynastyPerson.BirthDate = person.BirthDate;
            dynastyPerson.PartnerId = person.PartnerId;
            dynastyPerson.FaceId = person.FaceId;
            dynastyPerson.FatherId = person.FatherId;
            dynastyPerson.MotherId = person.MotherId;
            dynastyPerson.Name = person.Name;
            dynastyPerson.Surname = person.Surname;
            dynastyPerson.MiddleName = person.MiddleName;

            await _context.SaveChangesAsync();

            return RedirectToAction("EditForm", "Profile");
        }
    }
}
