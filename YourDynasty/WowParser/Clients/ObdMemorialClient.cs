using Newtonsoft.Json;
using System.Net;
using System.Reflection;
using WowPersonParser.Models.Dtos;

namespace WowPersonParser.Clients
{
    public class ObdMemorialClient: IObdMemorialClient
    {
        private readonly HttpClient _httpClient;

        private readonly string _searchPath = "html/search.htm";
        private readonly string _infoPath = "html/info.htm";
        private readonly string _baseUri = "http://www.obd-memorial.ru/";

        public ObdMemorialClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetList(PersonRequestDTO personRequest)
        {

            return File.ReadAllText("C:\\Users\\filil\\Desktop\\ОБД Мемориал.html");
        }

        public async Task<string> GetInfo(string id)
        {
           return File.ReadAllText("C:\\Users\\filil\\Desktop\\ОБД Мемориал __ Полковников Никита Пименович, красноармеец _ Сводная информация о человеке.html");
        }

        private static string BuildQueryString(PersonRequestDTO personRequest)
            => string.Join("&", personRequest.GetType().GetProperties()
                                 .Where(x => !string.IsNullOrEmpty(x.GetValue(personRequest)?.ToString()))
                                 .Select(p => $"{p.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName}{p.GetValue(personRequest)}"));

    }
}
