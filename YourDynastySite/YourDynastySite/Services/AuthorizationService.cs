using YourDynastySite.Database.Entities;
using YourDynastySite.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace YourDynastySite.Services
{
    public class AuthorizationService
    {
        private readonly ApplicationContext _context;
        private readonly IdentityV2PasswordHashService _passwordHasher;
        private readonly TokenHashSha512Service _tokenHasher;

        public AuthorizationService(
            ApplicationContext context,
            IdentityV2PasswordHashService passwordHasher,
            TokenHashSha512Service tokenHasher)
        {
            _context = context;
            _tokenHasher = tokenHasher;
            _passwordHasher = passwordHasher;
        }

        public async Task<string?> LoginAsync(LoginRequest request)
        {
            if (!string.IsNullOrEmpty(request.Email) && !string.IsNullOrEmpty(request.Password))
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == request.Email);
                if (user != null && user.PasswordHash != null)
                {
                    var passwordAreEquals = _passwordHasher
                        .VerifyHashedPassword(user.PasswordHash, request.Password);
                    if (passwordAreEquals)
                    {
                        var userToken = await _context.AuthorizationTokens
                            .Include(x => x.User)
                            .FirstOrDefaultAsync(x => x.User.Email == request.Email);
                        if (userToken != null)
                        {
                            _context.AuthorizationTokens.Remove(userToken);
                            await _context.SaveChangesAsync();
                        }
                        var guid = Guid.NewGuid();
                        var token = _tokenHasher.HashToken(request.Password, guid.ToString());
                        var newToken = new AuthorizationToken
                        {
                            Id = guid,
                            IsTest = false,
                            UserId = user.Id,
                            Expiration = DateTime.UtcNow.AddDays(7),
                            Token = token
                        };
                        await _context.AuthorizationTokens.AddAsync(newToken);
                        await _context.SaveChangesAsync();
                        return token;
                    }
                }
            }
            return null;
        }
    }
}