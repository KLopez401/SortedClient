using Newtonsoft.Json;
using SortedClient.Application.Dtos;
using SortedClient.Application.Interface;
using SortedClient.Domain.Models;
using System.Net.Http;

namespace SortedClient.Application.Concrete
{
    /// <summary>
    /// contains all the logic for measurement station
    /// </summary>
    public class MeasurementStationService : IMeasurementStationService
    {
        private readonly IHttpClientFactory _client;
        public MeasurementStationService(IHttpClientFactory httpClient)
        {
            _client = httpClient;
        }

        /// <summary>
        /// get method to connect to the api and read station with parameter rainfall
        /// </summary>
        /// <returns>
        /// returns the reading of all data from the rainfall api
        /// </returns>
        public async Task<IEnumerable<Items>> GetMeasurementStations(MeasureStationQueryDto stationQueryDto)
        {
            var items = new List<Items>();
            var httpClient = _client.CreateClient("Github");

            HttpResponseMessage response = await httpClient.GetAsync("id/stations?parameter=rainfall");

            if (response.IsSuccessStatusCode)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                var deserializeJson = JsonConvert.DeserializeObject<StationDto>(jsonString);

                if (deserializeJson != null)
                {
                    items = deserializeJson.Items;

                    items = FilterItems(items, stationQueryDto).ToList();
                }
            }

            return items;
        }
        /// <summary>
        /// method to filter items that pass items and stationquerydto value
        /// </summary>
        /// <param name="items"></param>
        /// <param name="stationQueryDto"></param>
        /// <returns>filtered items</returns>
        private IEnumerable<Items> FilterItems (List<Items> items, MeasureStationQueryDto stationQueryDto)
        {
            if (items.Any())
            {
                if (stationQueryDto.Qualifier.Any())
                {
                    items = items.Where(x => x.Measures.Any(y => y.Qualifier.Contains(stationQueryDto.Qualifier))).ToList();
                }

                if (stationQueryDto.RLOIid.Any())
                {
                    items = items.Where(x => x.RLOIid.Contains(stationQueryDto.RLOIid)).ToList();
                }

                if (stationQueryDto.Lat.Any())
                {
                    items = items.Where(x => x.Lat.Contains(stationQueryDto.Lat)).ToList();
                }

                if (stationQueryDto.Long.Any())
                {
                    items = items.Where(x => x.Long.Contains(stationQueryDto.Long)).ToList();
                }

                if (stationQueryDto.Search.Any())
                {
                    items = items.Where(x => x.Label.Contains(stationQueryDto.Search)).ToList();
                }
            }

            return items;
        }
    }
}
