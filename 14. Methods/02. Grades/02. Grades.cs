using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Write a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade in words
            //•	2.00 – 2.99 - "Fail"
            //•	3.00 – 3.49 - "Poor"
            //•	3.50 – 4.49 - "Good"
            //•	4.50 – 5.49 - "Very good"
            //•	5.50 – 6.00 - "Excellent"

            double grade = double.Parse(Console.ReadLine());

            gradesMethod(grade);
        }

        static void gradesMethod(double n)
        {
            if (n>=2 && n<=2.99)
            {
                Console.WriteLine($"Fail");
            }
            if (n >= 3 && n <= 3.49)
            {
                Console.WriteLine($"Poor");
            }
            if (n >= 3.5 && n <= 4.49)
            {
                Console.WriteLine($"Good");
            }
            if (n >= 4.5 && n <= 5.49)
            {
                Console.WriteLine($"Very good");
            }
            if (n >= 5.5 && n <= 6)
            {
                Console.WriteLine($"Excellent");
            }
        }
    }
}
