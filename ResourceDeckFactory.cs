using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantedSim.Factories
{
    public static class ResourceDeckFactory
    {
        public static List<ResourceCard> Create()
        {
            var deck = new List<ResourceCard>();

            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = "GreenThumb", Quantity = 2 }, 9));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = "Sun", Quantity = 1 }, 10));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = "Water", Quantity = 1 }, 10));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = "Fertilizer", Quantity = 1 }, 10));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = "Sun", Quantity = 2 }, 7));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = "Water", Quantity = 2 }, 7));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = "Fertilizer", Quantity = 2 }, 7));

            return deck;
        }
    }
}
