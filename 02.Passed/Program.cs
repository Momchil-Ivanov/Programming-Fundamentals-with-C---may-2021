using System;

namespace _02.Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take as an input a grade and check if the student has passed the exam (grade>=3.00)

            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
