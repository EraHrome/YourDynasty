namespace YourDynastySite.Database.Entities
{
    public class DynastyPerson
    {
        public Guid Id { get; set; }
        public Guid? MotherId { get; set; }
        public Guid? FatherId { get; set; }
        public Guid? PartnerId { get; set; }
        public int Gender { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public Guid FaceId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? DeathDate { get; set; }
        public string BurialRegion { get; set; }
        public string BurialPlace { get; set; }
        public string SourceLink { get; set; }
    }
}
