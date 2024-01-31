namespace SortedClient.Application.Dtos
{
    public class MeasureStationQueryDto
    {
        public string Qualifier { get; set; } = string.Empty;
        public string RLOIid { get; set; } = string.Empty;
        public string Lat { get; set; } = string.Empty;
        public string Long { get; set; } = string.Empty;
        public string Search { get; set; } = string.Empty;
    }
}
