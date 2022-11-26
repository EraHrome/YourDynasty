using WowPersonParsers.Models.Dtos;
using WowPersonParser.Clients;
using System.Reflection;
using Newtonsoft.Json;
using SeleniumParsers;

namespace WowPersonParsers.Clients
{
    public class ObdMemorialClient: IObdMemorialClient
    {
        private readonly SeleniumParser _selenium;

        private readonly string _searchPath = "html/search.htm";
        private readonly string _infoPath = "html/info.htm";
        private readonly string _baseUri = "http://www.obd-memorial.ru/";

        public ObdMemorialClient()
        {
            _selenium = new SeleniumParser();
        }

        public async Task<string> GetList(PersonRequestDTO personRequest)
        {
            var url = $"{_baseUri}{_searchPath}?{BuildQueryString(personRequest)}";
            var content = await Task.FromResult(_selenium.GetSiteContent(url, "//div[contains(@class, 'search-result__col-text-and-icons')]"));

            return content;
        }

        public async Task<string> GetInfo(string id)
        {
            var url = $"{_baseUri}{_infoPath}?id={id}";
            var content = await Task.FromResult(_selenium.GetSiteContent(url, "//div[contains(@class, 'card_parameter')]"));

            return content;
        }

        private static string BuildQueryString(PersonRequestDTO personRequest)
            => string.Join("&", personRequest.GetType().GetProperties()
                                 .Where(x => !string.IsNullOrEmpty(x.GetValue(personRequest)?.ToString()))
                                 .Select(p => $"{p.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName}{p.GetValue(personRequest)}"));

    }
}
