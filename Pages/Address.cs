namespace project1.Pages
{
    public class Address
    {
        public required string street { get; set; }
        public required string suite { get; set; }
        public required string city { get; set; }
        public required string zipCode { get; set; }

        public required Geo Geo { get; set; }
    }
}
