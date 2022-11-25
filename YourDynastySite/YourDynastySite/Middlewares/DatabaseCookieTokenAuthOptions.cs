using Microsoft.AspNetCore.Authentication;
using YourDynastySite.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;
using Models.Keys;
using YourDynastySite.Database.Contexts;

namespace YourDynastySite.Middlewares
{
    public class DatabaseCookieTokenAuthOptions : AuthenticationSchemeOptions
    {
        public string TokenName { get; set; } = AuthentificationKeys.UserAuthTokenKey;
    }

    public class DatabaseCookieTokenAuthHandler : AuthenticationHandler<DatabaseCookieTokenAuthOptions>
    {
        private readonly DbSet<AuthorizationToken> _dbSet;

        public DatabaseCookieTokenAuthHandler(
            ApplicationContext context,
            IOptionsMonitor<DatabaseCookieTokenAuthOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock)
        : base(options, logger, encoder, clock)
        {
            _dbSet = context.AuthorizationTokens;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Cookies.ContainsKey(Options.TokenName))
                return await Task.FromResult(AuthenticateResult.Fail($"Missing Cookie For Token: {Options.TokenName}"));

            var token = Request.Cookies[Options.TokenName];
            var tokenModel = await _dbSet.FirstOrDefaultAsync(x => x.Token == token);

            if (tokenModel == null)
            {
                return await Task.FromResult(AuthenticateResult.Fail($"Your token invalid: {Options.TokenName}"));
            }
            var isTestToken = tokenModel.IsTest.HasValue && tokenModel.IsTest.Value;
            if (!isTestToken && tokenModel.Expiration < DateTime.UtcNow)
            {
                _dbSet.Remove(tokenModel);
                return await Task.FromResult(AuthenticateResult.Fail($"Your token expired and was deleted: {Options.TokenName}"));
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Sid, tokenModel.Id.ToString()),
                new Claim(ClaimTypes.UserData, tokenModel.UserId.ToString()),
                new Claim(ClaimTypes.Expiration, tokenModel.Expiration.ToString()),
                new Claim(ClaimTypes.Name, tokenModel.User.Login.ToString())
            };

            var id = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(id);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            return await Task.FromResult(AuthenticateResult.Success(ticket));
        }
    }
}
