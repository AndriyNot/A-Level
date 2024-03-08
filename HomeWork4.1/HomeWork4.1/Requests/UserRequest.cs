using Newtonsoft.Json;

namespace HomeWork4._1.Requests
{
    public class UserRequest
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "job")]
        public string Job { get; set; }
    }
}
