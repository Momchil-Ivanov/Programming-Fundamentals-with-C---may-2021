using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, double> plantsRating = new Dictionary<string, double>();
            Dictionary<string, int> plantsRatingCounter = new Dictionary<string, int>();
            Dictionary<string, double> averageRatings = new Dictionary<string, double>();

            for (int i = 0; i < number; i++)
            {
                string[] currentPlant = Console.ReadLine().Split("<->").ToArray();

                string plant = currentPlant[0];
                int rarity = int.Parse(currentPlant[1]);

                if (plantsRarity.ContainsKey(plant))
                {
                    plantsRarity[plant] = rarity;
                }

                else
                {
                    plantsRarity.Add(plant, rarity);
                    plantsRating.Add(plant, 0);
                    plantsRatingCounter.Add(plant, 0);
                    averageRatings.Add(plant, 0);
                }
            }

            string[] command = Console.ReadLine().Split(" ").ToArray();

            while (command[0] != "Exhibition")
            {

                if (command[0] == "Rate:")
                {
                    if (command.Length != 4 || !plantsRarity.ContainsKey(command[1]) || command[2] != "-")
                    {
                        Console.WriteLine($"error");
                        return;
                    }

                    var stringNumber = command[3];
                    int numericValue;
                    bool isNumber = int.TryParse(stringNumber, out numericValue);

                    if (!isNumber)
                    {
                        Console.WriteLine($"error");
                        return;
                    }

                    string plant = command[1];
                    int rating = int.Parse(command[3]);

                    plantsRating[plant] += rating;
                    plantsRatingCounter[plant] += 1;
                }

                else if (command[0] == "Update:")
                {
                    if (command.Length != 4 || !plantsRarity.ContainsKey(command[1]) || command[2] != "-")
                    {
                        Console.WriteLine($"error");
                        return;
                    }

                    var stringNumber = command[3];
                    int numericValue;
                    bool isNumber = int.TryParse(stringNumber, out numericValue);

                    if (!isNumber)
                    {
                        Console.WriteLine($"error");
                        return;
                    }

                    string plant = command[1];
                    int newRarity = int.Parse(command[3]);

                    plantsRarity[plant] = newRarity;
                }

                else if (command[0] == "Reset:")
                {
                    if (command.Length != 2 || !plantsRating.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"error");
                        return;
                    }

                    string plant = command[1];
                    plantsRating[plant] = 0;
                    plantsRatingCounter[plant] = 0;
                }

                else
                {
                    Console.WriteLine($"error");
                    return;
                }

                command = Console.ReadLine().Split(" ").ToArray();
            }

            foreach (var plant in plantsRarity)
            {
                if (plantsRatingCounter[plant.Key] == 0)
                {
                    plantsRatingCounter[plant.Key] = 1;
                }

                averageRatings[plant.Key] += plantsRating[plant.Key] / plantsRatingCounter[plant.Key];
            }


            var ordered = plantsRarity.OrderByDescending(x => x.Value).ThenByDescending(x => averageRatings[x.Key]).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"Plants for the exhibition:");

            foreach (var plant in ordered)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {averageRatings[plant.Key]:f2}");
            }
        }
    }
}