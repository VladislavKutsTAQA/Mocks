using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class DayPartContent
    {
        [JsonPropertyName("DINNER")]
        public Dinner Dinner { get; set; }

        [JsonPropertyName("BREAKFAST")]
        public Breakfest Breakfest { get; set; }

        [JsonPropertyName("EVENING")]
        public Evening Evening { get; set; }

        [JsonPropertyName("OVERNIGHT")]
        public OverNight OverNight { get; set; }

        [JsonPropertyName("AFTERNOON")]
        public Afternoon Afternoon { get; set; }

        [JsonPropertyName("LUNCH")]
        public Lunch Lunch { get; set; }
    }
}