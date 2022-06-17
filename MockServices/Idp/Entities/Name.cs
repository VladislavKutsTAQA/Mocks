using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class Name
    {
        [JsonPropertyName("en")]
        public string En { get; set; }

        [JsonPropertyName("es")]
        public string Es { get; set; }
    }
}