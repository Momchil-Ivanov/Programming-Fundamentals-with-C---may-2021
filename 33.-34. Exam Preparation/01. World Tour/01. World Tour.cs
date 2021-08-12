using System;
using System.Linq;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string[] command = Console.ReadLine().Split(":").ToArray();
  
            while (command[0] != "Travel")
            {
                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    string stringToAdd = command[2];

                    if (index<0 || index>=stops.Length)
                    {
                        Console.WriteLine(stops);
                        command = Console.ReadLine().Split(":").ToArray();
                        continue;
                    }
                    else
                    {
                        stops = stops.Insert(index, stringToAdd);
                    }
                }

                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0 || startIndex >= stops.Length || endIndex < 0 || endIndex >= stops.Length)
                    {
                        Console.WriteLine(stops);
                        command = Console.ReadLine().Split(":").ToArray();
                        continue;
                    }
                    else
                    {
                        stops = stops.Remove(startIndex, endIndex-startIndex+1);    
                    }
                }

                else if (command[0] == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }
                }

                Console.WriteLine(stops);
                command = Console.ReadLine().Split(":").ToArray();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
