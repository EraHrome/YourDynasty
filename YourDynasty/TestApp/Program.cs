using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System;

namespace TestApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string testImageUri = "";

            IDictionary<string, string> defaultHeader = new Dictionary<string, string>();
            IDictionary<string, string> apiKey = new Dictionary<string, string>()
            {
            };
            IDictionary<string, string> apiKeyPrefix = new Dictionary<string, string>()
            {
            };

            Configuration config = new(defaultHeader, apiKey, apiKeyPrefix);
            //ApiClient client = new(config);
            RecognizeApi recognizeApi = new(config);

            MediaApi mediaApi = new(config);

            MediaUpload request = new MediaUpload(
                apiKey: Guid.Parse(apiKey.First().Value),
                fileUri: testImageUri);

            MediaUploadResponse response = mediaApi.V2MediaPost(request);

            Console.ReadKey();
        }
    }
}