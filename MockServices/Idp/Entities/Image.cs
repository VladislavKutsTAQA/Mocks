using System.Text.Json.Serialization;

namespace MockServices.Idp.Entities
{
    public class Image
    {
        [JsonPropertyName("assetId")]
        public string AssetId { get; set; }

        [JsonPropertyName("modification")]
        public string Modification { get; set; }
    }
}