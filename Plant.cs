using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantedSim.Models
{
    public class Plant
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("growth_stages")]
        public List<int>? Growth_Stages { get; set; }

        [JsonPropertyName("needs")]
        public ResourceNeeds? Needs { get; set; }

        public int GrowthCompleted { get; set; } = 0;

        public int TotalPoints => Growth_Stages?.Sum() ?? 0;
        public bool IsFullyGrown => GrowthCompleted >= (Growth_Stages?.Count ?? 0);
    }
}
