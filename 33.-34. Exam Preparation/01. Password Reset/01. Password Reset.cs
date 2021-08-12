using System;
using System.Linq;

namespace _33_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine().Split(" ").ToArray();

            while (command[0] != "Done")
            {
                if (command[0] == "TakeOdd")
                {
                    string newInput = string.Empty;
                    for (int i = 1; i < input.Length; i += 2)
                    {
                        newInput += input[i];
                    }
                    input = newInput;
                    Console.WriteLine(input);
                }
                else if (command[0] == "Cut")
                {
                    input = input.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    Console.WriteLine(input);
                }
                else if (command[0] == "Substitute")
                {
                    string substring = command[1];
                    string substitute = command[2];
                    if (!input.Contains(substring))
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                    else
                    {
                        while (input.Contains(substring))
                        {
                            input = input.Replace(substring, substitute);
                        }
                        Console.WriteLine(input);
                    }
                }
                command = Console.ReadLine().Split(" ").ToArray();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
