using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantedSim.Models;
using PlantedSim.Factories;

namespace PlantedSim.Models
{       
    public class GameState
        {
            public List<Player> Players { get; set; } = new();
            public List<Plant> CenterPlants { get; set; } = new();
            public int RoundNumber { get; set; } = 1;

            public static GameState CreateNewGame(List<Plant> allPlants)
            {
                var game = new GameState();
                var rand = new Random();

                // Split starter and non-starter plants
                var starterPool = allPlants.Where(p => p.IsStarter).OrderBy(_ => rand.Next()).ToList();
                var nonStarterPool = allPlants.Where(p => !p.IsStarter).OrderBy(_ => rand.Next()).ToList();

                // Create and shuffle resource and item decks
                var resourceDeck = ResourceDeckFactory.Create().OrderBy(_ => rand.Next()).ToList();
                var itemDeck = ItemDeckFactory.Create().OrderBy(_ => rand.Next()).ToList();

                // Create players
                for (int i = 0; i < 4; i++)
                {
                    var player = new Player
                    {
                        Name = $"Player {i + 1}",
                        Hand = resourceDeck.Take(6).ToList(),
                        Items = itemDeck.Take(2).ToList(),
                        Plants = new List<Plant> { starterPool[i] }
                    };

                    resourceDeck.RemoveRange(0, 6);
                    itemDeck.RemoveRange(0, 2);

                    game.Players.Add(player);
                }

                // Initialize 4 center plants
                game.CenterPlants = nonStarterPool.Take(4).ToList();

                return game;
            }
        }
    
}
