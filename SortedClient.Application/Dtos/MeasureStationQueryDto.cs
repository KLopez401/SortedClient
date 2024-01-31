namespace SortedClient.Application.Dtos
{
    /// <summary>
    /// a data transfer object for station query
    /// </summary>
    /// <remarks>
    /// used to transfer data from query filter request to the service
    /// </remarks>
    public class MeasureStationQueryDto
    {
        public string Qualifier { get; set; } = string.Empty;
        public string RLOIid { get; set; } = string.Empty;
        public string Lat { get; set; } = string.Empty;
        public string Long { get; set; } = string.Empty;
        public string Search { get; set; } = string.Empty;
    }
}
