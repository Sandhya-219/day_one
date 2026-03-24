using System.ComponentModel.DataAnnotations;

namespace project1.Pages
{
    public class Comments
    {
        public int postId { get; set; }
        public int id { get; set; }
        public required string name { get; set; }
        public required string email { get; set; }
        public required string body { get; set; }

    }
}
