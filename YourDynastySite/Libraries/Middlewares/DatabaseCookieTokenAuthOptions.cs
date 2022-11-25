using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Models.Keys;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace Middlewares
{
    public class DatabaseHeaderTokenAuthOptions : AuthenticationSchemeOptions
    {
        public string TokenName { get; set; } = AuthentificationKeys.UserAuthTokenKey;
    }

    public class DatabaseHeaderTokenAuthHandler : AuthenticationHandler<DatabaseHeaderTokenAuthOptions>
    {
        private readonly DbSet<AuthorizationToken> _dbSet;

        public DatabaseHeaderTokenAuthHandler(
            IAuthorizationTokenRepository authTokenRepository,
            IOptionsMonitor<DatabaseHeaderTokenAuthOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock)
        : base(options, logger, encoder, clock)
        {
            _authTokenRepository = authTokenRepository;
        }

        //Сейчас нет ролевой модели.
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey(Options.TokenName))
                return await Task.FromResult(AuthenticateResult.Fail($"Missing Header For Token: {Options.TokenName}"));

            var token = Request.Headers[Options.TokenName];
            var tokenModel = await _dbSet

            if (tokenModel == null)
            {
                return await Task.FromResult(AuthenticateResult.Fail($"Your token invalid: {Options.TokenName}"));
            }
            var isTestToken = tokenModel.IsTest.HasValue && tokenModel.IsTest.Value;
            if (!isTestToken && tokenModel.Expiration < DateTime.UtcNow)
            {
                await _authTokenRepository.Delete(tokenModel);
                return await Task.FromResult(AuthenticateResult.Fail($"Your token expired and was deleted: {Options.TokenName}"));
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Sid, tokenModel.Id.ToString()),
                new Claim(ClaimTypes.UserData, tokenModel.UserId.ToString()),
                new Claim(ClaimTypes.Expiration, tokenModel.Expiration.ToString()),
                new Claim(ClaimTypes.Role, tokenModel.User.Role.ToString()),
                new Claim(ClaimTypes.Name, tokenModel.User.Login.ToString())
            };

            var id = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(id);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            return await Task.FromResult(AuthenticateResult.Success(ticket));
        }
    }
}
