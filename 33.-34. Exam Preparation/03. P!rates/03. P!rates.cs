using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("||").ToArray();
            Dictionary<string, int> citiesPopulation = new Dictionary<string, int>();
            Dictionary<string, int> citiesGold = new Dictionary<string, int>();

            while (command[0] != "Sail")
            {
                string cityName = command[0];
                int cityPopulation = int.Parse(command[1]);
                int cityGold = int.Parse(command[2]);

                if (citiesPopulation.ContainsKey(cityName))
                {
                    citiesPopulation[cityName] += cityPopulation;
                    citiesGold[cityName] += cityGold;
                }
                else
                {
                    citiesPopulation.Add(cityName, cityPopulation);
                    citiesGold.Add(cityName, cityGold);
                }

                command = Console.ReadLine().Split("||").ToArray();
            }

            string[] eventHoHoHo = Console.ReadLine().Split("=>").ToArray();

            while (eventHoHoHo[0] != "End")
            {
                if (eventHoHoHo[0] == "Plunder")
                {
                    string cityName = eventHoHoHo[1];
                    int people = int.Parse(eventHoHoHo[2]);
                    int gold = int.Parse(eventHoHoHo[3]);

                    citiesPopulation[cityName] -= people;
                    citiesGold[cityName] -= gold;

                    Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (citiesPopulation[cityName] == 0 | citiesGold[cityName] == 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        citiesPopulation.Remove(cityName);
                        citiesGold.Remove(cityName);
                    }
                }

                else if (eventHoHoHo[0] == "Prosper")
                {
                    string cityName = eventHoHoHo[1];
                    int gold = int.Parse(eventHoHoHo[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        eventHoHoHo = Console.ReadLine().Split("=>").ToArray();
                        continue;
                    }

                    citiesGold[cityName] += gold;

                    Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {citiesGold[cityName]} gold.");
                }
                eventHoHoHo = Console.ReadLine().Split("=>").ToArray();
            }

            if (citiesPopulation.Count == 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesPopulation.Count} wealthy settlements to go to:");

                var ordered = citiesGold.OrderByDescending(x => x.Value).ThenBy(key => key.Key).ToDictionary(x => x.Key, x => x.Value);

                foreach (var city in ordered)
                {
                    Console.WriteLine($"{city.Key} -> Population: {citiesPopulation[city.Key]} citizens, Gold: {city.Value} kg");
                }
            }        
        }
    }
}
