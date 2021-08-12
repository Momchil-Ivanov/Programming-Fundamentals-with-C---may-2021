using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<int> intList = list.Select(int.Parse).ToList();
            List<int> sortList = new List<int>();

            double sum = 0;
            int fiveCounter = 5;
            for (int i = 0; i < intList.Count ; i++)
            {
                sum += intList[i];
            }
            sum /= intList.Count;
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i]>sum)
                {
                    sortList.Add(intList[i]);
                }
            }
            sortList.Sort();
            sortList.Reverse();

            if (sortList.Count==0)
            {
                Console.WriteLine($"No");
            }
            else
            {
                for (int i = 0; i < sortList.Count; i++)
                {
                    if (fiveCounter == 0)
                    {
                        break;
                    }
                    Console.Write($"{sortList[i]} ");
                    fiveCounter--;
                }
            }   
        }
    }
}
