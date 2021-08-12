using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //            You are given a working code that finds the volume of a pyramid.However, you should consider that the variables exceed their optimum span and have improper naming. Also, search for variables that have multiple purpose.
            //Hints
            //•	Reduce the span of the variables by declaring them in the moment they receive a value, not before
            //•	Rename your variables to represent their real purpose(example: "dul" should become length, etc.)
            //•	Search for variables that have multiple purpose.If you find any, introduce a new variable.

            double length, width, height = 0;
            
            length = double.Parse(Console.ReadLine());
            
            width = double.Parse(Console.ReadLine());
            
            height = double.Parse(Console.ReadLine());
            double V = (length * width * height) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {V:f2}");


        }
    }
}
