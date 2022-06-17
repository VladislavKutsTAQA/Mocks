using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class Evening
    {
        [JsonPropertyName("marketing")]
        public List<Marketing> Marketing { get; set; }

        [JsonPropertyName("upsell")]
        public List<UpSell> Upsell { get; set; }

        [JsonPropertyName("suggestiveSell")]
        public List<SuggestiveSell> SuggestiveSell { get; set; }
    }
}