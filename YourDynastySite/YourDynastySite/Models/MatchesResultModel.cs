using IO.Swagger.Model;
using YourDynastySite.Database.Entities;

namespace YourDynastySite.Models
{
    public class MatchesResultModel
    {
        public Guid FaceId { get; set; }
        public Recognize Recognize { get; set; }
        public List<(CroppedFace face, DynastyPerson person)>? Persons { get; set; }
    }
}
