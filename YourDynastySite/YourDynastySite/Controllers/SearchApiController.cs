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
        public async Task<IActionResult> GetList(SearchMemorialModel model)
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
                BurialPlace = model.BurialPlace
            });
            return Ok(res);
        }
    }
}
