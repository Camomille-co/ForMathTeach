using System.Drawing;

namespace jhyf.Data.Identity
{
    public class AddNews
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? NameFile { get; set; }   

        public string? ImageNews { get; set; }

        public string? Description { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime LastUpdated { get; set; }
    }
}