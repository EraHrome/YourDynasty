using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using Microsoft.AspNetCore.SignalR.Protocol;
using YourDynastySite.Services.Interfaces;

namespace YourDynastySite.Services
{
    public class DynastyService : IDynastyService
    {
        private readonly IFaceApi _faceService;
        private readonly IMediaApi _mediaService;
        private readonly IPersonApi _personService;
        private readonly IRecognizeApi _recognizeService;
        private readonly ITransformApi _transformService;

        private readonly Configuration _serviceConfiguration;

        private readonly Guid _apiKey;
        private readonly Guid _apiSecret;

        private const string _serviceConfigConst = "DynastyApi";
        private const string _apiKeyConst = "api_key";
        private const string _apiSecretConst = "api_secret";

        public DynastyService(IConfiguration configuration)
        {
            string apiKey = configuration[$"{_serviceConfigConst}:{_apiKeyConst}"];
            string apiSecret = configuration[$"{_serviceConfigConst}:{_apiSecretConst}"];

            _apiKey = Guid.Parse(apiKey);
            _apiSecret = Guid.Parse(apiSecret);

            _serviceConfiguration = new Configuration(
                new Dictionary<string, string>(),
                new Dictionary<string, string>()
                {
                    { _apiKeyConst, apiKey },
                },
                new Dictionary<string, string>()
                {
                    { _apiSecretConst, apiSecret }
                });

            _faceService = new FaceApi(_serviceConfiguration);
            _mediaService = new MediaApi(_serviceConfiguration);
            _personService = new PersonApi(_serviceConfiguration);
            _recognizeService = new RecognizeApi(_serviceConfiguration);
            _transformService = new TransformApi(_serviceConfiguration);
        }

        public async Task<Face> GetFace(Guid faceId)
           => await _faceService.V2FaceGetAsync(_apiKey, faceId);

        public async Task<CroppedFace> GetCroppedFace(Guid faceId)
            => await _faceService.V2FaceCroppedGetAsync(_apiKey, faceId);

        public async Task<MediaUploadResponse> UploadMedia(string? fileUri = null, string? fileBase64 = null)
            => await _mediaService.V2MediaPostAsync(new(_apiKey, fileUri, fileBase64));

        public async Task<Media> GetMedia(Guid mediaId)
            => await _mediaService.V2MediaGetAsync(_apiKey, mediaId);

        public async Task SetPersonFaces(IEnumerable<Guid> faces, string person)
            => await _personService.V2PersonPostAsync(new(_apiKey, faces.Select(faceId => (Guid?)faceId).ToList(), person));

        public async Task<List<Person>> GetPersonsFaces(List<string> persons)
            => await _personService.V2PersonGetAsync(_apiKey, _apiSecret, persons);

        public async Task<Recognize> Recognize(IEnumerable<Guid> faces, List<string>? targets = null)
            => await _recognizeService.V2RecognizePostAsync(new(_apiKey, faces.Select(faceId => (Guid?)faceId).ToList(), targets ?? new()));

        public async Task<ApiResponse<object>> GetRecognize(Guid recognizeId)
            => await _recognizeService.V2RecognizeGetAsyncWithHttpInfo(_apiKey, recognizeId);

        public async Task<Transform> Transform(IEnumerable<Guid> faces)
            => await _transformService.V2TransformPostAsync(new(_apiKey, faces.Select(faceId => (Guid?)faceId).ToList()));

        public async Task<ApiResponse<object>> GetTransform(Guid transformId)
            => await _transformService.V2TransformGetAsyncWithHttpInfo(_apiKey, transformId);
    }
}
