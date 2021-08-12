using System;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine().Split(">>>").ToArray();

            while (command[0] != "Generate")
            {
                if (command[0] == "Contains")
                {
                    string substring = command[1];

                    if (input.Contains(substring))
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }

                else if (command[0] == "Flip")
                {
                    string letterType = command[1];
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);

                    if (letterType == "Upper")
                    {
                        string oldInput = input.Substring(startIndex, endIndex-startIndex);
                        string newInput = input.Substring(startIndex, endIndex-startIndex).ToUpper();
                        input = input.Replace(oldInput, newInput);

                    }
                    else if (letterType == "Lower")
                    {
                        string oldInput = input.Substring(startIndex, endIndex - startIndex);
                        string newInput = input.Substring(startIndex, endIndex - startIndex).ToLower();
                        input = input.Replace(oldInput, newInput);
                    }

                    Console.WriteLine(input);
                }

                else if (command[0] == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    input = input.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(input);
                }

                command = Console.ReadLine().Split(">>>").ToArray();
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
