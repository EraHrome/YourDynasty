using WowPersonParsers.Models.Dtos;

namespace WowPersonParser.Clients
{
    public interface IObdMemorialClient
    {
        public Task<string> GetList(PersonRequestDTO personRequest);
        public Task<string> GetInfo(string id);
    }
}
