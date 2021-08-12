using System;
using System.Linq;


class Program
{
    static void Main()
    {
        //Write a program that determines if there exists an element in the array such that the sum of the elements on its left is equal to the sum of the elements on its right(there will never be more than 1 element like that). If there are no elements to the left / right, their sum is considered to be 0.Print the index that satisfies the required condition or "no" if there is no such index.

        int[] input = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();
        int sum = input.Sum();
        int checkSum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum -= input[i];
            if (sum == checkSum)
            {
                Console.WriteLine(i);
                return;
            }

            checkSum += input[i];
        }
        if (sum != checkSum)
        {
            Console.WriteLine("no");
        }
    }
}