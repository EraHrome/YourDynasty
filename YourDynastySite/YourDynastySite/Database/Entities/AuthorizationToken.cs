namespace YourDynastySite.Database.Entities
{
    public class AuthorizationToken
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime Expiration { get; set; }
        public string Token { get; set; } = null!;
        public bool? IsTest { get; set; }
    }
}
