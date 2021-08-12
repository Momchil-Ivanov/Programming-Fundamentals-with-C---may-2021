using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a method that calculates and returns the area of a rectangle by given width and height:

            double firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = int.Parse(Console.ReadLine());

            double area = calculateArea(firstNumber, secondNumber);
            Console.WriteLine(area);
        }

         static double calculateArea(double width, double height)
        {
            return width * height;
        }
    }
}
