using YourDynastySite.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace YourDynastySite.Database.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<AuthorizationToken> AuthorizationTokens { get; set; } = null!;

        public DbSet<DynastyPerson> DynastyPersons { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("...");
        //}

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
    }
}
