using Microsoft.AspNetCore.Mvc;
using YourDynastySite.Models;

namespace YourDynastySite.Controllers
{
    [Route("api/search")]
    public class SearchApiController : Controller
    {
        private readonly WowPersonParsers.WowPersonParser _parser;

        public SearchApiController(WowPersonParsers.WowPersonParser parser)
        {
            _parser = parser;
        }
       
        [HttpGet("memorial")]
        public async Task<IActionResult> MemorialList(SearchMemorialModel model)
        {
            var res = await _parser.GetPersons(new()
            {
                Name = model.Name,
                Surname = model.Surname,
                MiddleName = model.MiddleName,
                Birthday = model.Birthday,
                Birthplace = model.Birthplace,
                Country = model.Country,
                Region = model.Region,
                BurialPlace = model.BurialPlace,
                Page = model.Page != 0 ? model.Page : 1
            });

            if(model.Page > 1)
            {
                return View("~/Views/Search/MemorialPagerList.cshtml", new PersonsViewModel() { Persons = res.Persons ?? new(), Page = model.Page });
            }

            return View("~/Views/Search/MemorialList.cshtml", new PersonsViewModel() { Persons = res.Persons ?? new(), Page = model.Page });
        }
    }
}
