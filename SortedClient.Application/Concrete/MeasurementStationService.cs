using Newtonsoft.Json;
using SortedClient.Application.Interface;
using SortedClient.Domain.Models;

namespace SortedClient.Application.Concrete
{
    /// <summary>
    /// contains all the logic for measurement station
    /// </summary>
    public class MeasurementStationService : IMeasurementStationService
    {
        Uri baseUri = new Uri("https://environment.data.gov.uk/flood-monitoring/");
        private readonly HttpClient _client;
        public MeasurementStationService(HttpClient httpClient)
        {
            _client = httpClient;
        }

        /// <summary>
        /// get method to connect to the api and read station with parameter rainfall
        /// </summary>
        /// <returns>
        /// returns the reading of all data from the rainfall api
        /// </returns>
        public IEnumerable<Items> GetMeasurementStations()
        {
            var items = new List<Items>();
            string urlEndpoint = baseUri.ToString() + "id/stations?parameter=rainfall";
            HttpResponseMessage response = _client.GetAsync(urlEndpoint).Result;

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
