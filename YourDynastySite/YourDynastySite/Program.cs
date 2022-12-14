using YourDynastySite.Services;
using YourDynastySite.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Keys;
using YourDynastySite.Database.Contexts;
using YourDynastySite.Middlewares;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var config = builder.Configuration;

services.AddControllersWithViews();

services.AddDbContext<ApplicationContext>(
    options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

services.AddAuthentication(AuthentificationKeys.DefaultSchemeName)
    .AddScheme<DatabaseCookieTokenAuthOptions, DatabaseCookieTokenAuthHandler>
    (AuthentificationKeys.DefaultSchemeName, opt => { });

services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
services.AddScoped<AuthorizationService>();
services.AddScoped<IdentityV2PasswordHashService>();
services.AddScoped<TokenHashSha512Service>();
services.AddScoped<RegistrationService>();
services.AddScoped<WowPersonParsers.WowPersonParser>(x => new("chromedriver.exe"));

services.AddTransient<IDynastyService, DynastyService>();

services.AddRouting(op =>
{
    op.LowercaseUrls = true;
    op.LowercaseQueryStrings = false;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Use(async (context, next) =>
{
    if (context.Response.StatusCode == (int)HttpStatusCode.Unauthorized)
    {
        context.Response.Redirect($"/login?redirect={context.Request.Path}");
    }

    await next();
});

app.Run();
