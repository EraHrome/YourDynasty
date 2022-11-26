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
        public Guid FaceId { get; set; }
    }
}
