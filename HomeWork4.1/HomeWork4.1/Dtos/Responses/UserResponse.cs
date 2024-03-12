using Newtonsoft.Json;

namespace HomeWork4._1.Dtos.Responses
{
    public class UserResponse
    {
        [JsonProperty(PropertyName = "name")]
        public string Name {  get; set; }
        [JsonProperty(PropertyName = "job")]
        public string Job { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "createdAt")]
        public DateTimeOffset CreatedAd { get; set; }

    }
}
