using IO.Swagger.Client;
using IO.Swagger.Model;

namespace YourDynastySite.Services.Interfaces
{
    public interface IDynastyService
    {
        /// <summary>
        /// Получить информацию о лице по Id
        /// </summary>
        /// <param name="faceId">Id лица</param>
        /// <returns></returns>
        public Task<Face> GetFace(Guid faceId);
        /// <summary>
        /// Получить обрезанное изображение лица и информаци о нем
        /// </summary>
        /// <param name="faceId">Id лица</param>
        /// <returns></returns>
        public Task<CroppedFace> GetCroppedFace(Guid faceId);

        /// <summary>
        /// Загрузить изображение для распознования лиц
        /// Принимает или uri или base64
        /// </summary>
        /// <param name="fileUri">URI к изображению</param>
        /// <param name="fileBase64">Закодированное в base64 изображение. Если задан, параметр fileUrl игнорируется</param>
        /// <returns></returns>
        public Task<MediaUploadResponse> UploadMedia(string? fileUri = null, string? fileBase64 = null);
        /// <summary>
        /// Получение информации о ранее загруженном изображении по Id
        /// </summary>
        /// <param name="mediaId">Id ранее загруженного изображения</param>
        /// <returns></returns>
        public Task<Media> GetMedia(Guid mediaId);

        /// <summary>
        /// Задать нескольким лицам Id человека
        /// </summary>
        /// <param name="faces">Список Id лиц</param>
        /// <param name="person">Id человека</param>
        /// <returns></returns>
        public Task SetPersonFaces(IEnumerable<Guid> faces, string person);
        /// <summary>
        /// Получение списка лиц по Id людей
        /// </summary>
        /// <param name="persons">Список Id людей</param>
        /// <returns></returns>
        public Task<List<Person>> GetPersonsFaces(List<string> persons);

        /// <summary>
        /// Найти совпадения людей по Id лиц
        /// </summary>
        /// <param name="faces">Список Id лиц</param>
        /// <param name="targets">Id предпологаемых пользователей</param>
        /// <returns></returns>
        public Task<Recognize> Recognize(IEnumerable<Guid> faces, List<string>? targets = null);
        /// <summary>
        /// Получить информацию о распознавании по Id
        /// </summary>
        /// <param name="recognizeId">Id запроса на распознавание</param>
        /// <returns></returns>
        public Task<ApiResponse<object>> GetRecognize(Guid recognizeId);

        /// <summary>
        /// Преобразовать несколько изображений лиц в одно изображение
        /// </summary>
        /// <param name="faces">Список Id лиц</param>
        /// <returns></returns>
        public Task<Transform> Transform(IEnumerable<Guid> faces);
        /// <summary>
        /// Получить результат преобразования лиц по Id
        /// </summary>
        /// <param name="transformId">Id запроса на распознавание</param>
        /// <returns></returns>
        public Task<ApiResponse<object>> GetTransform(Guid transformId);
    }
}
