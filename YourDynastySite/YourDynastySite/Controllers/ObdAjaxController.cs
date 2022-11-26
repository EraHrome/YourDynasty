using WowPersonParsers.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace YourDynastySite.Controllers
{
    [Route("/search/obd")]
    [ApiController]
    public class ObdAjaxController : Controller
    {
        private readonly WowPersonParsers.WowPersonParser _parser;

        public ObdAjaxController(WowPersonParsers.WowPersonParser parser)
        {
            _parser = parser;
        }
       
        [HttpGet]
        public async Task<IActionResult> GetList(PersonRequestDTO requestDTO)
        {
            var res = await _parser.GetPersons(requestDTO);
            return Ok(res);
        }
    }
}
