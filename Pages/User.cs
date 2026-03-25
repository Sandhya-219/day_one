namespace project1.Pages
{
    public class User
    {
        public int id { get; set; }
        public required string name { get; set; }
        public required string userName { get; set; }
        public required string email { get; set; }
        public required string phone { get; set; }
        public required string website { get; set; }

        public required Address Address { get; set; }
        public required Company Company { get; set; }
               

    }
}
