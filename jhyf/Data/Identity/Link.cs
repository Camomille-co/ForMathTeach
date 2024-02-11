using System.ComponentModel.DataAnnotations.Schema;

namespace jhyf.Data.Identity
{
    [Table("Links", Schema = "data")]
    public class Link
    {
        public int Id { get; set; }

        public string NameFromLink { get; set; }

        public string Linki { get; set; }
    }
}
