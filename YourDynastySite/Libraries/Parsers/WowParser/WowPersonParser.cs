using HtmlAgilityPack;
using WowPersonParsers.Clients;
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
            personResponse.Persons = new List<Person>();
            var persons = personResponse.Persons;

            try
            {
                var content = await _obdMemorialClient.GetList(personRequest);
                if (!string.IsNullOrEmpty(content))
                {
                    HtmlDocument doc = new();
                    doc.LoadHtml(content);
                    var nodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'search-result')]");
                    var resNodes = nodes.Where(x => !String.IsNullOrWhiteSpace(x.Id));
                    foreach (var node in resNodes)
                    {
                        var infoContent = await _obdMemorialClient.GetInfo(node.Id);
                        if (!string.IsNullOrEmpty(infoContent))
                        {
                            HtmlDocument docInfo = new();
                            docInfo.LoadHtml(infoContent);
                            var nodeInfos = docInfo.DocumentNode.SelectNodes("//div[contains(@class, 'card_parameter')]");
                            if (nodeInfos != null)
                            {
                                var person = new Person();
                                foreach (var info in nodeInfos)
                                {
                                    var nameProp = info.SelectSingleNode(".//span[contains(@class, 'card_param-title')]").InnerText.Trim();
                                    var value = info.SelectSingleNode(".//span[contains(@class, 'card_param-result')]").InnerText.Trim();
                                    switch (nameProp)
                                    {
                                        case "Фамилия":
                                            person.Surname = value;
                                            break;
                                        case "Имя":
                                            person.Name = value;
                                            break;
                                        case "Отчество":
                                            person.MiddleName = value;
                                            break;
                                        case "Дата рождения/Возраст":
                                            person.Birthday = value;
                                            break;
                                        case "Место рождения":
                                            person.Birthplace = value;
                                            break;
                                        case "Дата и место призыва":
                                            person.Birthplace = value;
                                            break;
                                        case "Место службы":
                                            person.LastDutyStation = value;
                                            break;
                                        case "Воинское звание":
                                            person.Rank = value;
                                            break;
                                        case "Название источника донесения":
                                            person.Source = value;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                person.Link = ObdMemorialClient.GetInfoLink(node.Id);
                                person.Id = node.Id;
                                persons.Add(person);
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
