using Newtonsoft.Json;

namespace HomeWork4._1.Dtos.Responses
{
    public class RegisterResponse
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
    }
}
