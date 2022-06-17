using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class Product
    {
        [JsonPropertyName("image")]
        public Image Image { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}