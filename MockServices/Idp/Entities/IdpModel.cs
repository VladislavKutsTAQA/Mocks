using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class IdpModel
    {
        [JsonPropertyName("menu")]
        public Menu Menu { get; set; }

        [JsonPropertyName("dayPartContent")]
        public DayPartContent DayPartContent { get; set; }
    }
}