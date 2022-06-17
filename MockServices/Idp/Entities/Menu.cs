using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class Menu
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("products")]
        public List<Product> Products { get; set; }

        [JsonPropertyName("activeFrom")]
        public object ActiveFrom { get; set; }

        [JsonPropertyName("activeTo")]
        public object ActiveTo { get; set; }
    }
}