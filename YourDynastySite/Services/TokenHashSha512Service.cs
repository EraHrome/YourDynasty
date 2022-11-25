using System.Security.Cryptography;
using System.Text;

namespace Services
{
    public class TokenHashSha512Service
    {
        public TokenHashSha512Service() { }

        public string HashToken(string password, string salt)
        {
            using (SHA512 shaM = new SHA512Managed())
            {
                var data = Encoding.UTF8.GetBytes(password + salt);
                var hash = shaM.ComputeHash(data);
                return BitConverter.ToString(hash);
            }
        }
    }
}
