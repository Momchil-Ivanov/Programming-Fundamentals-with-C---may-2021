using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args) // проверяваме дали в диапазон от 1 до n има числа, които се делят на 8 без остатък и същевременно имат поне една нечетна цифра в себе
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                bool isDivisible = IsDivisible(i);
                bool oneOdd = OneOdd(i);

                if (isDivisible && oneOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool OneOdd(int i)
        {
            bool oneOdd = false;
            while (i > 0)
            {
                if (i % 10 == 1 || i % 10 == 3 || i % 10 == 5 || i % 10 == 7 || i % 10 == 9)
                {
                    oneOdd = true;
                }
                i /= 10;
            }
            return oneOdd;
        }

        private static bool IsDivisible(int i)
        {
            bool isDivisible = false;
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 8 == 0)
            {
                isDivisible = true;
            }
            return isDivisible;
        }
    }
}
