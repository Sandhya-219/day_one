namespace project1.Pages
{
    public class Photos
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public required string title { get; set; }
        public required string url { get; set; }
        public required string thumbNailUrl { get; set; }
    }
}
