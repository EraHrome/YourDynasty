using YourDynastySite.Database.Entities;
using YourDynastySite.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace YourDynastySite.Services
{
    public class RegistrationService
    {
        private readonly ApplicationContext _context;
        private readonly IdentityV2PasswordHashService _passwordHasher;

        public RegistrationService(
            ApplicationContext context,
            IdentityV2PasswordHashService passwordHasher)
        {
            _context = context;
            _passwordHasher = passwordHasher;
        }

        public async Task<bool> Register(RegistrationRequest request)
        {
            var requestUser = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Email);
            if (requestUser == null)
            {
                var passwordHash = _passwordHasher.HashPassword(request.Password);
                var newUser = new User()
                {
                    Login = request.Login,
                    Email = request.Email,
                    PasswordHash = passwordHash
                };
                await _context.Users.AddAsync(newUser);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
