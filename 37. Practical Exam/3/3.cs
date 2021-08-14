using System;
using System.Collections.Generic;
using System.Linq;

namespace _0
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> peoplesHealth = new Dictionary<string, int>();
            Dictionary<string, int> peoplesEnergy = new Dictionary<string, int>();

            string[] command = Console.ReadLine().Split(":").ToArray();

            while (command[0] != "Results")
            {
                if (command[0] == "Add")
                {
                    string personName = command[1];
                    int health = int.Parse(command[2]);
                    int energy = int.Parse(command[3]);

                    if (peoplesHealth.ContainsKey(personName))
                    {
                        peoplesHealth[personName] += health;
                    }
                    else
                    {
                        peoplesHealth.Add(personName, health);
                        peoplesEnergy.Add(personName, energy);
                    }
                }

                else if (command[0] == "Attack")
                {
                    string attackerName = command[1];
                    string defenderName = command[2];
                    int damage = int.Parse(command[3]);

                    if (peoplesHealth.ContainsKey(attackerName) && peoplesHealth.ContainsKey(defenderName))
                    {
                        peoplesHealth[defenderName] -= damage;
                        if (peoplesHealth[defenderName] <= 0)
                        {
                            Console.WriteLine($"{defenderName} was disqualified!");
                            peoplesHealth.Remove(defenderName);
                            peoplesEnergy.Remove(defenderName);
                        }

                        peoplesEnergy[attackerName] -= 1;
                        if (peoplesEnergy[attackerName] <= 0)
                        {
                            Console.WriteLine($"{attackerName} was disqualified!");
                            peoplesHealth.Remove(attackerName);
                            peoplesEnergy.Remove(attackerName);
                        }
                    }
                }

                else if (command[0] == "Delete")
                {
                    string username = command[1];

                    if (username == "All")
                    {
                        peoplesHealth = new Dictionary<string, int>();
                        peoplesEnergy = new Dictionary<string, int>();
                    }
                    else
                    {
                        if (peoplesHealth.ContainsKey(username))
                        {
                            peoplesHealth.Remove(username);
                            peoplesEnergy.Remove(username);
                        }
                    }
                }

                command = Console.ReadLine().Split(":").ToArray();
            }

            Console.WriteLine($"People count: {peoplesHealth.Count}");

            var ordered = peoplesHealth.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var person in ordered)
            {
                Console.WriteLine($"{person.Key} - {person.Value} - {peoplesEnergy[person.Key]}");
            }
        }
    }
}
