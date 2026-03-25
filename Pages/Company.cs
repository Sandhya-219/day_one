using System.Text.Json.Serialization;

namespace project1.Pages
{
    public class Company
    {
        [JsonPropertyName("name")]
        public required string companyName { get; set; }
        public required string catchPhrase { get; set; }
        public required string bs { get; set; }
    }
}
