using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class UpSell
    {
        [JsonPropertyName("productsToSell")]
        public List<ProductsToSell> ProductsToSell { get; set; }

        [JsonPropertyName("productsToBuy")]
        public List<ProductsToBuy> ProductsToBuy { get; set; }

        [JsonPropertyName("dayPart")]
        public string DayPart { get; set; }

        [JsonPropertyName("activeFrom")]
        public string ActiveFrom { get; set; }

        [JsonPropertyName("activeTo")]
        public string ActiveTo { get; set; }
    }
}