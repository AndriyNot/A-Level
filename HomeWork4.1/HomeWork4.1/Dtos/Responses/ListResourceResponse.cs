using Newtonsoft.Json;
namespace HomeWork4._1.Dtos.Responses
{
    public class ListResourceResponse
    {
        [JsonProperty(PropertyName = "page")]
        public string Page { get; set; }
        [JsonProperty(PropertyName = "pare_page")]
        public int PerPage { get; set; }
        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }
        [JsonProperty(PropertyName = "total_pages")]
        public int TotalPages { get; set; }
        [JsonProperty(PropertyName = "data")]
        public List<ResourceDto> UsersResource { get; set; }
    }
}
