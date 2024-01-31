using Microsoft.AspNetCore.Mvc;
using SortedClient.Application.Dtos;
using SortedClient.Application.Interface;
using SortedClient.Domain.Models;

namespace SortedClient.Api.Controllers
{
    /// <summary>
    /// Controller for measurementstation 
    /// </summary>
    /// <remarks>
    /// includes all the specified logic in rainfall measurement
    /// </remarks>
    [Route("api/rainfall/id/[action]/")]
    [ApiController]
    public class MeasurementStationController : ControllerBase
    {
        IMeasurementStationService _measurementStationService;
        /// <summary>
        ///  Inject the IMeasurementStationService
        /// </summary>
        public MeasurementStationController(IMeasurementStationService measurementStationService)
        {
            _measurementStationService = measurementStationService;
        }

        /// <summary>
        /// All rainfall measurement stations
        /// </summary>
        /// <remarks>
        /// Retrieve the latest readings for measurement stations
        /// </remarks>
        [HttpGet()]
        [ProducesResponseType(typeof(Items), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Stations([FromQuery] MeasureStationQueryDto stationQueryDto)
        {
            var items = await _measurementStationService.GetMeasurementStations(stationQueryDto);
            return Ok(items);
        }
    }
}
