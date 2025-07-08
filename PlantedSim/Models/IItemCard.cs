using System;

namespace PlantedSim.Models
{
    public interface IItemCard
    {
        string Name { get; }
        string Type { get; } // "Tool" or "Decoration"
    }
}
