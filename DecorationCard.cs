using System;

namespace PlantedSim.Models
{
    public class DecorationCard : IItemCard
    {
        public string Name { get; set; } = string.Empty;
        public string Type => "Decoration";
        public string Description { get; set; } = string.Empty;
        public int BasePoints { get; set; } = 0;
    }
}
