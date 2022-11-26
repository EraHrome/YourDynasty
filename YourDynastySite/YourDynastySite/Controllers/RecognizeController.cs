﻿using IO.Swagger.Model;
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
                DynastyPerson person = await _context.DynastyPersons.FirstOrDefaultAsync(p => p.FatherId == face);
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


            return View();
        }

        public async Task<IActionResult> GenealogyTree(Guid personId)
        {
            Guid test1 = Guid.NewGuid();
            Guid test2 = Guid.NewGuid();
            Guid test3 = Guid.NewGuid();

            GenealogyTreeModel veiwModel = new()
            {
                Persons = new()
                {
                    new(){ Id = test1, PartnerId = test2, Name = "Test1", FaceId = test1, Gender = 0},
                    new(){ Id = test2, PartnerId = test1, Name = "Test2", FaceId = test1, Gender = 1},
                    new(){ Id = test3, FatherId = test1, MotherId = test2, Name = "Test3", FaceId = test1, Gender = 0},
                }
            };

            return View(veiwModel);
        }
    }
}