using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //            A number is special when its sum of digits is 5, 7 or 11.
            //Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).
            //Examples
            //Input   Output
            //15  1->False
            //2->False
            //3->False
            //4->False
            //5->True
            //6->False
            //7->True
            //8->False
            //9->False
            //10->False
            //11->False
            //12->False
            //13->False
            //14->True
            //15->False

            int number = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int sum = 0;
            int currentNumber = 0;



            for (int i = 0; i < number; i++)
            {
                firstNumber++;
               
                    currentNumber = firstNumber;
                    while (currentNumber>=10)
                    {   
                        sum += (currentNumber-currentNumber%10)/10;
                        currentNumber = currentNumber % 10;
                    }
                    sum += currentNumber;            
                

                

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{firstNumber} -> True");
                }
                else
                {
                    Console.WriteLine($"{firstNumber} -> False");
                }

                currentNumber = 0;
                sum = 0;

            }


        }
    }
}
