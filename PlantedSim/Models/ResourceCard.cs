using System;
using System.Text.Json.Serialization;

namespace PlantedSim.Models
{

    public enum ResourceType
    {
        Sun,
        Water,
        Fertilizer,
        GreenThumb
    }
    public class ResourceCard
    {

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ResourceType? Type { get; set; }
        public int Quantity { get; set; }
    }
}
