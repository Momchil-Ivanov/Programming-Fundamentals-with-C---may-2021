using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which prints common elements in two arrays. You have to compare the elements of the second array to the elements of the first.

            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');         

            for (int i = 0; i < secondArray.Length; i++)
            {
                string currentElement = secondArray[i];

                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (currentElement == firstArray[j])
                    {
                        Console.Write(currentElement + " ");
                    }
                }
            }
        }
    }
}
