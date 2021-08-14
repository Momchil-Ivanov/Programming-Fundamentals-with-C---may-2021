using System;
using System.Linq;

namespace _37
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] command = Console.ReadLine().Split(" ").ToArray();

            bool starts = true;

            while (command[0] != "End")
            {
                if (command[0] == "Translate")
                {
                    string symbol = command[1];
                    string replacement = command[2];

                    while (input.Contains(symbol))
                    {
                        input = input.Replace(symbol, replacement);
                    }

                    Console.WriteLine(input);
                }

                else if (command[0] == "Includes")
                {
                    string stringToCheck = command[1];

                    if (input.Contains(stringToCheck))
                    {
                        Console.WriteLine($"True");
                    }
                    else
                    {
                        Console.WriteLine($"False");
                    }
                }

                else if (command[0] == "Start")
                {
                    string stringToStart = command[1];

                    if (input.Length < stringToStart.Length)
                    {
                        Console.WriteLine($"False");
                        command = Console.ReadLine().Split(" ").ToArray();
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < stringToStart.Length; i++)
                        {
                            if (input[i] != stringToStart[i])
                            {
                                Console.WriteLine($"False");
                                starts = false;
                                break;
                            }
                        }
                        if (starts)
                        {
                            Console.WriteLine($"True");
                        }
                    }

                    starts = true;
                }

                else if (command[0] == "Lowercase")
                {
                    input = input.ToLower();

                    Console.WriteLine(input);
                }

                else if (command[0] == "FindIndex")
                {
                    string charToFind = command[1];

                    for (int i = input.Length - 1; i >= 0; i--)
                    {
                        if (input[i].ToString() == charToFind)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }

                else if (command[0] == "Remove")
                {
                    int startIndex = int.Parse(command[1]);
                    int count = int.Parse(command[2]);

                    input = input.Remove(startIndex, count);

                    Console.WriteLine(input);
                }

                command = Console.ReadLine().Split(" ").ToArray();
            }
        }
    }
}
