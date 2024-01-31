using Microsoft.AspNetCore.Mvc;
using SortedClient.Application.Dtos;
using SortedClient.Domain.Models;

namespace SortedClient.Application.Interface
{
    /// <summary>
    /// IMeasurementStationService interface to be implemented on a class
    /// </summary>
    public interface IMeasurementStationService
    {
        /// <summary>
        /// Get Measurement station method
        /// </summary>
        Task<IEnumerable<Items>> GetMeasurementStations([FromQuery] MeasureStationQueryDto stationQueryDto);
    }
}
