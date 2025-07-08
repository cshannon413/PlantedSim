using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using PlantedSim.Models;
using PlantedSim.Factories;

namespace PlantedSim
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\cshan\\Downloads\\planted_plants.json";
            if (!File.Exists(path))
            {
                Console.WriteLine("Could not find planted_plants.json");
                return;
            }

            var json = File.ReadAllText(path);
            var plants = JsonSerializer.Deserialize<List<Plant>>(json);

            if (plants == null)
            {
                Console.WriteLine("Failed to parse plant list.");
                return;
            }

            Console.WriteLine($"Loaded {plants.Count} plants.\n");

            foreach (var plant in plants)
            {
                Console.WriteLine($"{plant.Name} ({plant.Type}) - Total Points: {plant.TotalPoints}");
                Console.WriteLine($"  Growth Stages: {string.Join(", ", plant.Growth_Stages)}");
                Console.WriteLine($"  Needs - Sun: {plant.Needs?.Sun}, Water: {plant.Needs?.Water}, Fertilizer: {plant.Needs?.Fertilizer}\n");
            }

            var starterPlants = plants.Where(p => p.IsStarter).ToList();
            Console.WriteLine($"\nFound {starterPlants.Count} starter plants.");

            foreach (var starter in starterPlants)
            {
                Console.WriteLine($"Starter: {starter.Name} ({starter.Type})");
            }

            Console.WriteLine("\nGenerating resource deck...");
            var resourceDeck = ResourceDeckFactory.Create();
            var grouped = resourceDeck.GroupBy(c => $"{c.Type}-{c.Quantity}").Select(g => new { g.Key, Count = g.Count() });

            foreach (var group in grouped)
            {
                Console.WriteLine($"{group.Key}: {group.Count}");
            }

            Console.WriteLine("\nGenerating item deck...");
            var itemDeck = ItemDeckFactory.Create();
            foreach (var item in itemDeck)
            {
                if (item is ToolCard tool)
                {
                    Console.WriteLine($"{tool.Name} [Tool] - When you play a {tool.TriggerType} {tool.TriggerResource}, gain {tool.BonusAmount} {tool.BonusType}");
                }
                else if (item is DecorationCard deco)
                {
                    Console.WriteLine($"{deco.Name} [Decoration] - {deco.Description} (+{deco.BasePoints} pts)");
                }
            }
        }
    }
}
