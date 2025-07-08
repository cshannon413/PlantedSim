using System;
using System.Collections.Generic;
using System.Linq;
using PlantedSim.Models;

namespace PlantedSim.Factories
{
    public static class ResourceDeckFactory
    {
        public static List<ResourceCard> Create()
        {
            var deck = new List<ResourceCard>();

            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = ResourceType.GreenThumb, Quantity = 2 }, 9));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = ResourceType.Sun, Quantity = 1 }, 10));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = ResourceType.Water, Quantity = 1 }, 10));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = ResourceType.Fertilizer, Quantity = 1 }, 10));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = ResourceType.Sun, Quantity = 2 }, 7));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = ResourceType.Water, Quantity = 2 }, 7));
            deck.AddRange(Enumerable.Repeat(new ResourceCard { Type = ResourceType.Fertilizer, Quantity = 2 }, 7));

            return deck;
        }
    }
}
