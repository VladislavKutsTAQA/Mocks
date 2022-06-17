using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class Marketing
    {
        [JsonPropertyName("dayPart")]
        public string DayPart { get; set; }

        [JsonPropertyName("assets")]
        public List<Asset> Assets { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("activeFrom")]
        public string ActiveFrom { get; set; }

        [JsonPropertyName("activeTo")]
        public string ActiveTo { get; set; }
    }
}