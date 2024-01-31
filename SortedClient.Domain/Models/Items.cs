using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedClient.Domain.Models
{
    /// <summary>
    /// Item model that is used when deserializing object from jsonstring based on the api return value
    /// </summary>
    public class Items
    {
        [JsonProperty("@id")]
        public string Id { get; set; } = string.Empty;
        [JsonProperty("easting")]
        public string Easting { get; set; } = string.Empty;
        [JsonProperty("gridReference")]
        public string GridReference { get; set; } = string.Empty;
        [JsonProperty("label")]
        public string Label { get; set; } = string.Empty;
        [JsonProperty("lat")]
        public string Lat { get; set; } = string.Empty;
        [JsonProperty("long")]
        public string Long { get; set; } = string.Empty;
        [JsonProperty("measures")]
        public List<Measures> Measures { get; set; } = new List<Measures>();
        [JsonProperty("northing")]
        public string Northing { get; set; } = string.Empty;
        [JsonProperty("notation")]
        public string Notation { get; set; } = string.Empty;
        [JsonProperty("stationReference")]
        public string StationReference { get; set; } = string.Empty;
    }

    /// <summary>
    /// Station model is used to for deserializing jsonstring to object
    /// </summary>
    public class Stations
    {
        public List<Items> Items { get; set; } = new List<Items>();
    }
}
