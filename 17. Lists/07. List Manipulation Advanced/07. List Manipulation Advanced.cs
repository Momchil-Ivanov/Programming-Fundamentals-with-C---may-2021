using System;
using System.Collections.Generic;
using System.Linq;

namespace _00._Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> numbersOriginal = new List<int>(numbers);

            string command = Console.ReadLine();

            bool change = false;

            while (command != "end")
            {

                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Filter")
                {
                    string condition = commandArgs[1];

                    int element = int.Parse(commandArgs[2]);

                    if (condition == "<")
                    {
                        List<int> testedNumbers = new List<int>(numbers);
                        testedNumbers.RemoveAll(n => n >= element);
                        Console.WriteLine(string.Join(" ", testedNumbers));
                    }

                    if (condition == ">")
                    {
                        List<int> testedNumbers = new List<int>(numbers);
                        testedNumbers.RemoveAll(n => n <= element);
                        Console.WriteLine(string.Join(" ", testedNumbers));
                    }

                    if (condition == "<=")
                    {
                        List<int> testedNumbers = new List<int>(numbers);
                        testedNumbers.RemoveAll(n => n > element);
                        Console.WriteLine(string.Join(" ", testedNumbers));
                    }

                    if (condition == ">=")
                    {
                        List<int> testedNumbers = new List<int>(numbers);
                        testedNumbers.RemoveAll(n => n < element);
                        Console.WriteLine(string.Join(" ", testedNumbers));
                    }

                }

                if (action == "Add")
                {
                    int element = int.Parse(commandArgs[1]);

                    numbers.Add(element);
                    change = true;
                }

                if (action == "Remove")
                {
                    int element = int.Parse(commandArgs[1]);

                    numbers.Remove(element);

                    change = true;

                }

                if (action == "RemoveAt")
                {
                    int element = int.Parse(commandArgs[1]);

                    numbers.RemoveAt(element);

                    change = true;

                }

                if (action == "Insert")
                {
                    int element = int.Parse(commandArgs[1]);

                    int index = int.Parse(commandArgs[2]);
                    numbers.Insert(index, element);

                    change = true;

                }

                if (action == "Contains")
                {
                    int element = int.Parse(commandArgs[1]);

                    numbers.Contains(element);
                    if (numbers.Contains(element) == true)
                    {
                        Console.WriteLine($"Yes");
                    }
                    if (numbers.Contains(element) == false)
                    {
                        Console.WriteLine($"No such number");
                    }
                }

                if (action == "PrintEven")
                {
                    List<int> testedNumbers = new List<int>(numbers);
                    testedNumbers.RemoveAll(n => n % 2 != 0);
                    Console.WriteLine(string.Join(" ", testedNumbers));

                }

                if (action == "PrintOdd")
                {
                    List<int> testedNumbers = new List<int>(numbers);
                    testedNumbers.RemoveAll(n => n % 2 == 0);
                    Console.WriteLine(string.Join(" ", testedNumbers));

                }

                if (action == "GetSum")
                {
                    List<int> testedNumbers = new List<int>(numbers);
                    Console.WriteLine(testedNumbers.Sum());
                }


                command = Console.ReadLine();
            }

            if (change)

            {
                Console.WriteLine(string.Join(" ", numbers));

            }

        }
    }
}
