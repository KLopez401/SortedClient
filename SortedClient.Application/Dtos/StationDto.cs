using SortedClient.Domain.Models;

namespace SortedClient.Application.Dtos
{
    /// <summary>
    /// Station model is used to for deserializing jsonstring to object
    /// </summary>
    public class StationDto
    {
        public List<Items> Items { get; set; } = new List<Items>();
    }
}
