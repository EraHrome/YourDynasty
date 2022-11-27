using YourDynastySite.Database.Entities;

namespace YourDynastySite.Models
{
    public class GenealogyTreeModel
    {
        public List<DynastyPersonWithImage> Persons { get; set; }
    }

    public class DynastyPersonWithImage
    {
        public DynastyPerson Person { get; set; }
        public string Image { get; set; }
    }
}
