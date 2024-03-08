using Newtonsoft.Json;

namespace HomeWork4._1.Dtos
{
    public class ResourceDto
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "year")]
        public int Year { get; set; }
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
        [JsonProperty(PropertyName = "pantone_value")]
        public string PantoneValue { get; set; }
    }
}
