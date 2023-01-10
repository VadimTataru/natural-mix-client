using Newtonsoft.Json;

namespace NaturalMixWebClient.Models
{
    public class RecognizedTextResponse
    {
        [JsonProperty("RecognizedText")]
        public string Text { get; set; }
        [JsonProperty("Data")]
        public List<ComponentResponse> Data { get; set; }
    }
}
