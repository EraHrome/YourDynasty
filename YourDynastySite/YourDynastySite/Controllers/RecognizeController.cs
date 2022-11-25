using Microsoft.AspNetCore.Mvc;
using YourDynastySite.Services.Interfaces;

namespace YourDynastySite.Controllers
{
    public class RecognizeController : Controller
    {
        private readonly IDynastyService _dynastyService;

        public RecognizeController(IDynastyService dynastyService)
        {
            _dynastyService = dynastyService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Upload()
        {
            return View();
        }
    }
}
