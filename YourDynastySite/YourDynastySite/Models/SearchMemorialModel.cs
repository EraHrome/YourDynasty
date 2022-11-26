using Microsoft.AspNetCore.Mvc;

namespace YourDynastySite.Models
{
    public class SearchMemorialModel
    {
        [FromQuery]
        public string Name { get; set; }

        [FromQuery]
        public string Surname { get; set; }

        [FromQuery]
        public string MiddleName { get; set; }

        [FromQuery]
        public string Birthday { get; set; }

        [FromQuery]
        public string Birthplace { get; set; }

        [FromQuery]
        public string Country { get; set; }

        [FromQuery]
        public string Region { get; set; }

        [FromQuery]
        public string BurialPlace { get; set; }

        [FromQuery]
        public string Rang { get; set; }

        [FromQuery]
        public int Page { get; set; }
    }
}
