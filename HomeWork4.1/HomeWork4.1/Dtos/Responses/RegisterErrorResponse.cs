using Newtonsoft.Json;
namespace HomeWork4._1.Dtos.Responses
{
    public class RegisterErrorResponse
    {
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
    }
}
