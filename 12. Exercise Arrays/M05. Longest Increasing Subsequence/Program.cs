
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;

namespace LargestSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray(); // четем вход

            int[] index = new int[nums.Length]; // отчитаме броят на числата на входа

            int maxIndex = 0; // задаваме максимален индекс 0
            for (int i = 0; i < nums.Length; i++) //завърваме цикъл nums на брой пъти
            {
                for (int j = 0; j < i; j++) // цикъл, който сравнява всяко с всяко друго число
                {
                    if (nums[j] < nums[i] && index[j] > index[i] - 1) // лявото число (i) е по-голямо и се намира по-наляво от дясното (j)
                    {
                        index[i] = index[j] + 1; // числото на позиция i ще е с 1 по-надясно от j
                        if (index[i] > index[maxIndex])
                        {
                            maxIndex = i; // максималния индекс, където трябва да приключим
                        }
                    }
                }
            }

            Print(maxIndex, nums, index); // метод
        }

        static void Print(int maxIndex, int[] nums, int[] index)
        {
            bool isFirst = true; // дали ще имаме най-малко число
            for (int i = 0; i < maxIndex; i++) // проверява всички индекси от началния до този, съответстващ на най-голямото число
            {
                if (nums[i] < nums[maxIndex] && index[i] == index[maxIndex] - 1 && isFirst) // числото при i не може да е по-надясно при MaxIndex
                {
                    isFirst = false;
                    Print(i, nums, index);
                }
            }

            Console.Write(nums[maxIndex] + " "); // започваме отпечатването на число при най-голям индекс с най-ниска стойност 
        }
    }
}
