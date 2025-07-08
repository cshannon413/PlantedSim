using System;

namespace PlantedSim.Models
{
    public class ToolCard : IItemCard
    {
        public string Name { get; set; } = string.Empty;
        public string Type => "Tool";
        public string TriggerType { get; set; } = string.Empty;
        public string TriggerResource { get; set; } = string.Empty;
        public string BonusType { get; set; } = string.Empty;
        public int BonusAmount { get; set; } = 1;
    }
}

