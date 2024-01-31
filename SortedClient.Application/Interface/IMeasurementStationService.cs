using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        Task<IEnumerable<Items>> GetMeasurementStations();
    }
}
