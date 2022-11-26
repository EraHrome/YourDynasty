using Microsoft.AspNetCore.Mvc;

namespace YourDynastySite.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
