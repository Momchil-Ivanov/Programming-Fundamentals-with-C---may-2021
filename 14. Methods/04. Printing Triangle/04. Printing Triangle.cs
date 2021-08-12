using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method for printing triangles as shown below:

            int number = int.Parse(Console.ReadLine());
            triangleMethod(number);
        }

        static void triangleMethod(int n)
        {
            for (int row = 0; row <= n; row++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();                
            }

            for (int row = n - 1; row >= 1; row--)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
