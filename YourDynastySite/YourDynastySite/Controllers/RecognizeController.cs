using IO.Swagger.Model;
using Microsoft.AspNetCore.Mvc;
using YourDynastySite.Models;
using YourDynastySite.Services.Interfaces;

namespace YourDynastySite.Controllers
{
    public class RecognizeController : Controller
    {
        private readonly IDynastyService _dynastyService;

        public RecognizeController(IDynastyService dynastyService)
        {
            _dynastyService = dynastyService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload(RecognizeUploadModel model)
        {
            byte[] bytes;
            using (var memoryStream = new MemoryStream())
            {
                model.File.CopyTo(memoryStream);
                bytes = memoryStream.ToArray();
            }
            string base64 = Convert.ToBase64String(bytes);

            MediaUploadResponse response = await _dynastyService.UploadMedia(fileBase64: base64);

            List<Guid> facesIds = response.Media.Faces.Where(face => face.FaceUuid.HasValue).Select(face => face.FaceUuid.Value).ToList();

            List<CroppedFace> faces = new List<CroppedFace>();
            foreach (var faceId in facesIds)
            {
                faces.Add(await _dynastyService.GetCroppedFace(faceId));
            }

            UploadResultViewModel viewModel = new()
            {
                Response = response,
                Image = base64,
                Faces = faces
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Matches()
        {
            return View();
        }
    }
}
