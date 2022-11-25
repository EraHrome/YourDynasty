using Microsoft.EntityFrameworkCore;
using Models.Keys;
using YourDynastySite.Database.Contexts;
using YourDynastySite.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var config = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
services.AddAuthentication(AuthentificationKeys.DefaultSchemeName)
    .AddScheme<DatabaseCookieTokenAuthOptions, DatabaseCookieTokenAuthHandler>
    (AuthentificationKeys.DefaultSchemeName, opt => { });

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
