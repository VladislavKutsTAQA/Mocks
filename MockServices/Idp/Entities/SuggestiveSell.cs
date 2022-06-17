using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class SuggestiveSell
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("dayPart")]
        public string DayPart { get; set; }

        [JsonPropertyName("activeFrom")]
        public string ActiveFrom { get; set; }

        [JsonPropertyName("activeTo")]
        public string ActiveTo { get; set; }

        [JsonPropertyName("assets")]
        public List<Asset> Assets { get; set; }
    }
}