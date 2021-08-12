using System;
using System.Collections.Generic;
using System.Linq;

namespace _24._Associative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();
            var numbersArray = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (!numbers.ContainsKey(numbersArray[i]))
                {
                    numbers.Add(numbersArray[i], 0);
                }
                numbers[numbersArray[i]]++;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
