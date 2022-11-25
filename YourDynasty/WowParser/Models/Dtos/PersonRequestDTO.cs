using Newtonsoft.Json;

namespace WowPersonParser.Models.Dtos
{
    public class PersonRequestDTO
    { 
        [JsonProperty("entity=")]
        public string Entity { get; } = "111111111111111";

        [JsonProperty("entities=")]
        public string Entitites { get; } = "9003,7003,8001,6006,6007,30,32,9,18,26,25,24,28,27,23,34,22,20,21,19";

        [JsonProperty("f=P~")]
        public string Surname { get; set; }

        [JsonProperty("n=P~")]
        public string Name { get; set; }

        [JsonProperty("s=P~")]
        public string MiddleName { get; set; }

        [JsonProperty("bd=P~")]
        public string Birthday { get; set; }

        [JsonProperty("pb=T~")]
        public string Birthplace { get; set; }

        [JsonProperty("d=T~")]
        public string Recruitment { get; set; }

        [JsonProperty("lp=T~")]
        public string LastDutyStation { get; set; }

        [JsonProperty("r=P~")]
        public string Rang { get; set; }

        [JsonProperty("dateout=P~")]
        public string Dateout { get; set; }

        [JsonProperty("placeout=T~")]
        public string Placeout { get; set; }

        [JsonProperty("hosp=T~")]
        public string Hospital { get; set; }

        [JsonProperty("from=T~")]
        public string ReburialPlace { get; set; }

        [JsonProperty("add=T~")]
        public string Additional { get; set; }

        [JsonProperty("lagnum=P~")]
        public string CampNumber { get; set; }

        [JsonProperty("grave=T~")]
        public string FirstBurialPlace { get; set; }

        [JsonProperty("capt=T~")]
        public string СaptivityPlace { get; set; }

        [JsonProperty("camp=T~")]
        public string Camp { get; set; }

        [JsonProperty("dd=P~")]
        public string DieDate { get; set; }

        [JsonProperty("country=T~")]
        public string Country { get; set; }

        [JsonProperty("region=T~")]
        public string Region { get; set; }

        [JsonProperty("place=T~")]
        public string BurialPlace { get; set; }

        [JsonProperty("fulltext=")]
        public string FullText { get; set; }

        [JsonProperty("ps=")]
        public int PageSize { get; } = 100;
    }
}
