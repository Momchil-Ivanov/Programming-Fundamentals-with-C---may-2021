using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int peopleCounter = peopleCount;
            List<string> liftState = Console.ReadLine().Split(' ').ToList();
            List<int> intLiftState = liftState.Select(int.Parse).ToList();

            for (int i = 0; i < intLiftState.Count; i++)
            {
                for (int j = 0; j < peopleCounter; j++)
                {
                    if (intLiftState[i]<4 && peopleCount>0)
                    {
                        intLiftState[i] += 1;
                        peopleCount--;
                    } 
                }
            }
            for (int i = 0; i < intLiftState.Count; i++)
            {
                if (intLiftState[i] < 4)
                {
                    Console.WriteLine($"The lift has empty spots!");
                    Console.WriteLine(String.Join(' ', intLiftState));
                    return;
                }
            }
            if (peopleCount>0)
            {
                Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
                Console.WriteLine(String.Join(' ', intLiftState));
            }
            else
            {
                Console.WriteLine(String.Join(' ', intLiftState));
            }
          
        }
    }
}
