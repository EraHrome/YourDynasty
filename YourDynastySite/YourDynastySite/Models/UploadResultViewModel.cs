using IO.Swagger.Model;

namespace YourDynastySite.Models
{
    public class UploadResultViewModel
    {
        public MediaUploadResponse? Response { get; set; }
        public List<CroppedFace>? Faces { get; set; }
        public string? Image { get; set; }
    }
}
