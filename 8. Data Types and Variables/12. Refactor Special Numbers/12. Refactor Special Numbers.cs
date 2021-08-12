using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a working code that is a solution to Problem 5.Special Numbers.However, the variables are improperly named, declared before they are needed and some of them are used for multiple things. Without using your previous solution, modify the code so that it is easy to read and understand.

            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecialNum = false;
            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNum);
                sum = 0;
                i = currentNumber;
            }

        }
    }
}
