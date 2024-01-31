using Microsoft.AspNetCore.Mvc;
using SortedClient.Application.Concrete;
using SortedClient.Application.Interface;
using SortedClient.Domain.Models;

namespace SortedClient.Api.Controllers
{
    /// <summary>
    /// Controller for measurementstation 
    /// </summary>
    /// <description>
    /// includes all the specified logic in rainfall measurement
    /// </description>
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
        /// <description> 
        /// Retrieve the latest readings for measurement stations
        /// </description>
        /// <tags>
        /// Rainfall
        /// </tags>
        [HttpGet()]
        [ProducesResponseType(typeof(Items), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Stations()
        {
            var items = _measurementStationService.GetMeasurementStations();
            return Ok(items);
        }
    }
}
