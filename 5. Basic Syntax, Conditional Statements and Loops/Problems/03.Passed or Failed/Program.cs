using System;

namespace _03.Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take as an input a grade and check if the student has passed the exam (grade>=3.00)
            //Upgrade the last example, so it prints "Failed!", if the mark is lower than 3.00

            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }

            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
