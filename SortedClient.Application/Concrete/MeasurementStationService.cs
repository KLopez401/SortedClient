using Newtonsoft.Json;
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
        public async Task<IEnumerable<Items>> GetMeasurementStations()
        {
            var items = new List<Items>();
            var httpClient = _client.CreateClient("Github");

            HttpResponseMessage response = await httpClient.GetAsync("id/stations?parameter=rainfall");

            if (response.IsSuccessStatusCode)
            {
                string jsonString = response.Content.ReadAsStringAsync().Result;
                var deserializeJson = JsonConvert.DeserializeObject<Stations>(jsonString);

                if (deserializeJson != null)
                {
                    items = deserializeJson.Items;
                }
            }

            return items;
        }
    }
}
