using WowPersonParsers.Models;

namespace YourDynastySite.Models
{
    public class PersonsViewModel
    {
        public List<Person> Persons { get; set; }
        public int Page { get; set; }
    }
}
