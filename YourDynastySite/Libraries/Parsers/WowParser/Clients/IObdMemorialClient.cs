using WowPersonParsers.Models.Dtos;

namespace WowPersonParser.Clients
{
    public interface IObdMemorialClient
    {
        Task<string> GetList(PersonRequestDTO personRequest);
        Task<string> GetInfo(string id);
        void CloseConnection();
    }
}
