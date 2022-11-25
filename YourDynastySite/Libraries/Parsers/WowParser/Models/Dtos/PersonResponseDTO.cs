namespace WowPersonParsers.Models.Dtos
{
    public class PersonResponseDTO
    {
        public PersonResponseDTO() => Persons = new();

        public List<Person> Persons { get; set; }
        public bool IsSuccess { get; set; }
        public string Exception { get; set; }
    }
}
