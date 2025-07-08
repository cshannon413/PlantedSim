using System;
using System.Collections.Generic;
using System.Linq;
using PlantedSim.Models;

namespace PlantedSim.Factories
{
    public static class ItemDeckFactory
    {
        public static List<IItemCard> Create()
        {
            var items = new List<IItemCard>();

            // Tool cards
            items.AddRange(Enumerable.Repeat(new ToolCard { Name = "Grow Light", TriggerType = "Double", TriggerResource = "Sun", BonusType = "Sun" }, 3));
            items.AddRange(Enumerable.Repeat(new ToolCard { Name = "Watering Can", TriggerType = "Double", TriggerResource = "Water", BonusType = "Water" }, 3));
            items.AddRange(Enumerable.Repeat(new ToolCard { Name = "Potting Mix", TriggerType = "Double", TriggerResource = "Fertilizer", BonusType = "Fertilizer" }, 3));
            items.AddRange(Enumerable.Repeat(new ToolCard { Name = "Window Planter", TriggerType = "Single", TriggerResource = "Sun", BonusType = "GreenThumb" }, 4));
            items.AddRange(Enumerable.Repeat(new ToolCard { Name = "Spray Bottle", TriggerType = "Single", TriggerResource = "Water", BonusType = "GreenThumb" }, 4));
            items.AddRange(Enumerable.Repeat(new ToolCard { Name = "Fertilizer", TriggerType = "Single", TriggerResource = "Fertilizer", BonusType = "GreenThumb" }, 4));

            // Decoration cards
            items.AddRange(Enumerable.Repeat(new DecorationCard { Name = "Workbench", Description = "1 point for each tool you have", BasePoints = 0 }, 3));
            items.AddRange(Enumerable.Repeat(new DecorationCard { Name = "Indoor Greenhouse", Description = "1 point for each fully grown plant you have", BasePoints = 0 }, 4));
            items.AddRange(Enumerable.Repeat(new DecorationCard { Name = "Display Shelf", Description = "3 points for each complete set of Hanging, Floor, and Shelf plants", BasePoints = 0 }, 2));
            items.AddRange(Enumerable.Repeat(new DecorationCard { Name = "Plant Stand", Description = "1 point for each Floor plant you have", BasePoints = 0 }, 4));
            items.AddRange(Enumerable.Repeat(new DecorationCard { Name = "Macrame Basket", Description = "1 point for each Hanging plant you have", BasePoints = 0 }, 4));
            items.AddRange(Enumerable.Repeat(new DecorationCard { Name = "Ceramic Planter", Description = "1 point for each Shelf plant you have", BasePoints = 0 }, 4));

            return items;
        }
    }
}
