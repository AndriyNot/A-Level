using Newtonsoft.Json;
namespace HomeWork4._1.Dtos.Responses
{
    public class LoginResponse
    {
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
    }
}
