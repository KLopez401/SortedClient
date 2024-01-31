using Newtonsoft.Json;

namespace SortedClient.Domain.Models
{
    /// <summary>
    /// Measures model that is used when deserializing object from jsonstring based on the api return value
    /// </summary>
    public class Measures
    {
        [JsonProperty("@id")]
        public string Id { get; set; } = string.Empty;
        [JsonProperty("paramater")]
        public string Parameter { get; set; } = string.Empty;
        [JsonProperty("parameterName")]
        public string ParameterName { get; set; } = string.Empty;
        [JsonProperty("period")]
        public string Period { get; set; } = string.Empty;
        [JsonProperty("qualifier")]
        public string Qualifier { get; set; } = string.Empty;
        [JsonProperty("unitName")]
        public string UnitName { get; set; } = string.Empty;
    }
}
