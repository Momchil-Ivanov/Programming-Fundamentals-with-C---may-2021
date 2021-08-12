using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            if (numberOne >= numberTwo && numberOne >= numberThree && numberTwo >= numberThree)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberThree);
            }
            else if (numberTwo >= numberOne && numberTwo >= numberThree && numberOne >= numberThree)
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberOne);
                Console.WriteLine(numberThree);
            }
            else if (numberThree >= numberTwo && numberThree >= numberOne && numberOne >= numberTwo)
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberOne);
                Console.WriteLine(numberTwo);
            }
            else if (numberOne >= numberTwo && numberOne >= numberThree && numberTwo <= numberThree)
            {
                Console.WriteLine(numberOne);
                Console.WriteLine(numberThree);
                Console.WriteLine(numberTwo);
            }
            else if (numberTwo >= numberOne && numberTwo >= numberThree && numberOne <= numberThree)
            {
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberThree);
                Console.WriteLine(numberOne);
            }
            else if (numberThree >= numberTwo && numberThree >= numberOne && numberOne <= numberTwo)
            {
                Console.WriteLine(numberThree);
                Console.WriteLine(numberTwo);
                Console.WriteLine(numberOne);
            }

        }
    }
}
