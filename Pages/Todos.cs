namespace project1.Pages
{
    public class Todos
    {
        public int userId { get; set; }
        public int id { get; set; }
        public required string title { get; set; }
        public required bool completed { get; set; }
    }
}
