using IO.Swagger.Client;
using IO.Swagger.Model;

namespace YourDynastySite.Services.Interfaces
{
    public interface IDynastyService
    {
        public Task<Face> GetFace(Guid faceId);
        public Task<CroppedFace> GetCroppedFace(Guid faceId);

        public Task<MediaUploadResponse> UploadMedia(string? fileUri = null, string? fileBase64 = null);
        public Task<Media> GetMedia(Guid mediaId);

        public Task SetPersonFaces(IEnumerable<Guid> faces, string person);
        public Task<List<Person>> GetPersonsFaces(List<string> persons);

        public Task<Recognize> Recognize(IEnumerable<Guid> faces, List<string> targets);
        public Task<ApiResponse<object>> GetRecognize(Guid recognizeId);
    }
}
