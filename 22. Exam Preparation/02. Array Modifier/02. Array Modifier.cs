using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrayValues = Console.ReadLine().Split(' ').ToList();
            List<int> intArrayValues = arrayValues.Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> partsOfCommands = command.Split(' ').ToList();
                if (partsOfCommands[0] == "swap")
                {
                    int firstIndex = int.Parse(partsOfCommands[1]);
                    int secondIndex = int.Parse(partsOfCommands[2]);
                    int firstIndexOriginalValue = intArrayValues[firstIndex];
                    int secondIndexOriginalValue = intArrayValues[secondIndex];

                    intArrayValues.RemoveAt(firstIndex);
                    intArrayValues.Insert(firstIndex, secondIndexOriginalValue);
                    intArrayValues.RemoveAt(secondIndex);
                    intArrayValues.Insert(secondIndex, firstIndexOriginalValue);
                }
                if (partsOfCommands[0] == "multiply")
                {
                    int firstIndex = int.Parse(partsOfCommands[1]);
                    int secondIndex = int.Parse(partsOfCommands[2]);
                    int firstIndexMultiplied = intArrayValues[firstIndex] * intArrayValues[secondIndex];

                    intArrayValues.RemoveAt(firstIndex);
                    intArrayValues.Insert(firstIndex, firstIndexMultiplied);
                }
                if (partsOfCommands[0] == "decrease")
                {
                    for (int i = 0; i < intArrayValues.Count; i++)
                    {
                        intArrayValues[i]--;
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", intArrayValues));
        }
    }
}
