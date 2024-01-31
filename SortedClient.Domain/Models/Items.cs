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
        [JsonProperty("RLOIid")]
        public string RLOIid { get; set; } = string.Empty;
        [JsonProperty("catchmentName")]
        public string CatchmentName { get; set; } = string.Empty;
        [JsonProperty("dateOpened")]
        public string DateOpened { get; set; } = string.Empty;
        [JsonProperty("datumOffset")]
        public string DatumOffset { get; set; } = string.Empty;
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
        [JsonProperty("riverName")]
        public string RiverName { get; set; } = string.Empty;
        [JsonProperty("stageScale")]
        public string StageScale { get; set; } = string.Empty;
        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;
        [JsonProperty("town")]
        public string Town { get; set; } = string.Empty;
        [JsonProperty("stationReference")]
        public string StationReference { get; set; } = string.Empty;
        [JsonProperty("wiskiID")]
        public string WiskiID { get; set; } = string.Empty;
    }
}
