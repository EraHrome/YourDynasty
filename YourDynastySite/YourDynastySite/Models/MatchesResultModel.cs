using IO.Swagger.Model;

namespace YourDynastySite.Models
{
    public class MatchesResultModel
    {
        public Guid FaceId { get; set; }
        public Recognize Recognize { get; set; }
        public List<CroppedFace>? Faces { get; set; }
    }
}
