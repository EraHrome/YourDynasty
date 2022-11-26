using HtmlAgilityPack;
using Newtonsoft.Json;
using WowPersonParsers.Clients;
using WowPersonParsers.Helpers;
using WowPersonParsers.Models;
using WowPersonParsers.Models.Dtos;

namespace WowPersonParsers
{
    public class WowPersonParser
    {
        private readonly ObdMemorialClient _obdMemorialClient;

        public WowPersonParser()
        {
            _obdMemorialClient = new();
        }

        public async Task<PersonResponseDTO> GetPersons(PersonRequestDTO personRequest)
        {
            PersonResponseDTO personResponse = new();

            try
            {
                var content = await _obdMemorialClient.GetList(personRequest);
                if (!string.IsNullOrEmpty(content))
                {
                    HtmlDocument doc = new();
                    doc.LoadHtml(content);
                    var nodes = doc.DocumentNode.SelectNodes("//[@class='search-result']");
                    foreach (var node in nodes)
                    {
                        var infoContent = await _obdMemorialClient.GetInfo(node.Id);
                        if (!string.IsNullOrEmpty(infoContent))
                        {
                            string json = string.Empty;
                            HtmlDocument docInfo = new();
                            docInfo.LoadHtml(content);
                            var nodeInfos = doc.DocumentNode.SelectNodes("//[@class='card_parameter']");
                            foreach (var info in nodeInfos)
                            {
                                var nameProp = info.SelectSingleNode("//[@class='card_param-title']").InnerText.GetPropName();
                                var value = info.SelectSingleNode("//[@class='card_param-result']").InnerText;
                                json += $"\"{nameProp}\":\"{value}\"";
                            }

                            var result = JsonConvert.DeserializeObject<Person>($"{{{json}}}");
                            if (result is not null)
                            {
                                result.Id = node.Id;
                                personResponse.Persons.Add(result);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                personResponse.IsSuccess = false;
                personResponse.Exception = ex.Message;
            }

            return personResponse;
        }

    }
}
