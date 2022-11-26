using IO.Swagger.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YourDynastySite.Database.Contexts;
using YourDynastySite.Database.Entities;
using YourDynastySite.Models;
using YourDynastySite.Services.Interfaces;

namespace YourDynastySite.Controllers
{
    public class RecognizeController : Controller
    {
        private readonly IDynastyService _dynastyService;

        private readonly ApplicationContext _context;

        private const string _dbName = "yourdynasty.com";
        private const string _allNames = "all";

        public RecognizeController(
            IDynastyService dynastyService,
            ApplicationContext context)
        {
            _dynastyService = dynastyService;
            _context = context;
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

            List<CroppedFace> faces = new();
            foreach (var faceId in facesIds)
            {
                CroppedFace face = await _dynastyService.GetCroppedFace(faceId);
                string personId = face.Face.PersonId;
                faces.Add(face);

                if (string.IsNullOrEmpty(personId))
                {
                    Guid personGuid = Guid.NewGuid();
                    await _dynastyService.SetPersonFaces(new List<Guid>() { faceId }, $"{personGuid}@{_dbName}");
                }
            }

            UploadResultViewModel viewModel = new()
            {
                Response = response,
                Image = base64,
                Faces = faces
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Matches(Guid faceId)
        {
            Recognize recognize;
            try
            {
                recognize = await _dynastyService.Recognize(new List<Guid>() { faceId }, new List<string>() { $"{_allNames}@{_dbName}" });
            }
            catch (Exception ex)
            {
                return RedirectToAction(nameof(AddPerson), faceId);
            }

            if (recognize?.Results == null || recognize.Results.Count == 0)
            {
                return RedirectToAction(nameof(AddPerson));
            }

            List<Guid> facesIds = recognize.Results.Where(recognize => recognize.FaceUuid.HasValue && recognize.FaceUuid == faceId)
                .FirstOrDefault().Matches.Where(match => match.FaceUuid.HasValue).Select(match => match.FaceUuid.Value).ToList();

            List<(CroppedFace face, DynastyPerson Person)> persons = new();
            foreach (var face in facesIds)
            {
                CroppedFace croppedFace = await _dynastyService.GetCroppedFace(face);
                DynastyPerson person = await _context.DynastyPersons.FirstOrDefaultAsync(p => p.FaceId == face);
                persons.Add((croppedFace, person));
            }

            MatchesResultModel viewModel = new MatchesResultModel()
            {
                FaceId = faceId,
                Recognize = recognize,
                Persons = persons
            };

            return View(viewModel);
        }

        public async Task<IActionResult> AddPerson(DynastyPerson person)
        {
            DynastyPerson? dynastyPerson = null;

            if (person.Id != new Guid())
            {
                dynastyPerson = _context.DynastyPersons.FirstOrDefault(p => p.Id == person.Id);
            }

            if (dynastyPerson == null)
            {
                person.Id = Guid.NewGuid();
                await _context.DynastyPersons.AddAsync(person);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Matches), new { faceId = person.FaceId });
            }

            dynastyPerson.BirthPlace = person.BirthPlace;
            dynastyPerson.Gender = person.Gender;
            dynastyPerson.BirthDate = person.BirthDate;
            dynastyPerson.DeathDate = person.DeathDate;
            dynastyPerson.SourceLink = person.SourceLink;
            dynastyPerson.PartnerId = person.PartnerId;
            dynastyPerson.FaceId = person.FaceId;
            dynastyPerson.FatherId = person.FatherId;
            dynastyPerson.MotherId = person.MotherId;
            dynastyPerson.Name = person.Name;
            dynastyPerson.Surname = person.Surname;
            dynastyPerson.MiddleName = person.MiddleName;
            dynastyPerson.BurialPlace = person.BurialPlace;
            dynastyPerson.BurialRegion = person.BurialRegion;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Matches), new { faceId = person.FaceId });
        }

        public async Task<IActionResult> GenealogyTree(Guid personId)
        {
            GenealogyTreeModel viewModel = new()
            {
                Persons = new()
            };
            var res = await GetPersonTree(viewModel, personId);
            return View(res);
        }

        public async Task<GenealogyTreeModel> GetPersonTree(GenealogyTreeModel treeModel, Guid personId)
        {
            var person = await _context.DynastyPersons.FirstOrDefaultAsync(x => x.Id == personId);
            if (person == null)
            {
                return treeModel;
            }
            treeModel.Persons.Add(person);
            var existingIds = treeModel.Persons.Select(x => x.Id);
            if (person.PartnerId.HasValue && !existingIds.Any(x => existingIds.Contains(person.PartnerId.Value)))
            {
                var partners = await GetPersonTree(treeModel, person.PartnerId.Value);
                treeModel.Persons.AddRange(partners.Persons);
            }
            if (person.MotherId.HasValue && !existingIds.Any(x => existingIds.Contains(person.MotherId.Value)))
            {
                var motherTree = await GetPersonTree(treeModel, person.MotherId.Value);
                treeModel.Persons.AddRange(motherTree.Persons);
            }
            if (person.FatherId.HasValue && !existingIds.Any(x => existingIds.Contains(person.FatherId.Value)))
            {
                var fatherTree = await GetPersonTree(treeModel, person.FatherId.Value);
                treeModel.Persons.AddRange(fatherTree.Persons);
            }
            var persons = new List<DynastyPerson>();
            foreach (var pers in treeModel.Persons)
            {
                if (!persons.Any(x => x.Id == pers.Id))
                {
                    persons.Add(pers);
                }
            }
            treeModel.Persons = persons;
            return treeModel;
        }
    }
}