using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YourDynastySite.Models;

namespace YourDynastySite.Controllers
{
    public class SearchController : Controller
    {
        public SearchController() { }
        
        /// <summary>
        /// Страница поиска людей в сервисе obd memorial
        /// </summary>
        /// <returns></returns>
        //[Authorize]
        [HttpGet("search/memorial")]
        public async Task<IActionResult> Memorial(SearchMemorialModel model)
        {
            return View();
        }
    }
}
