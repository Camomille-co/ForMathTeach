using System.Drawing;

namespace jhyf.Data.Identity
{
    public class AddNews
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public Image? ImageNews { get; set; }

        public string? Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}