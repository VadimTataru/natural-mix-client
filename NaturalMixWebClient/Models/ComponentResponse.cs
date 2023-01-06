using Newtonsoft.Json;

namespace NaturalMixWebClient.Models
{
    public class ComponentResponse
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Description")]
        public string? Description { get; set; }
        [JsonProperty("Origin")]
        public string? Origin { get; set; }
        [JsonProperty("Naturalness")]
        public float? Naturalness { get; set; }
    }
}
