using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PlantedSim.Models
{
    public class Player
    {
        public string Name { get; set; } = string.Empty;
        public List<Plant> Plants { get; set; } = new();         // Includes starter + any gained later
        public List<ResourceCard> Hand { get; set; } = new();
        public List<IItemCard> Items { get; set; } = new();

        public int Suns { get; set; } = 0;
        public int Waters { get; set; } = 0;
        public int Fertilizers { get; set; } = 0;
        public int GreenThumbs { get; set; } = 0;

        public void ApplyResource(ResourceCard card)
        {
            switch (card.Type)
            {
                case ResourceType.Sun:
                    Suns += card.Quantity;
                    break;
                case ResourceType.Water:
                    Waters += card.Quantity;
                    break;
                case ResourceType.Fertilizer:
                    Fertilizers += card.Quantity;
                    break;
                case ResourceType.GreenThumb:
                    GreenThumbs += card.Quantity;
                    break;
            }
        }

        public int CalculateScore()
        {
            int plantPoints = Plants.Sum(p => p.Growth_Stages?.Take(p.GrowthCompleted).Sum() ?? 0);
            int decorationPoints = Items.OfType<DecorationCard>().Sum(d => d.BasePoints); // placeholder
            return plantPoints + decorationPoints;
        }
    }
}
