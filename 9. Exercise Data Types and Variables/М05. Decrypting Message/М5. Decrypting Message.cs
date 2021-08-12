using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            //            You will receive n lines.On those lines, you will receive one of the following:
            //•	Opening bracket – “(“,
            //•	Closing bracket – “)” or
            //•	Random string
            //Your task is to find out if the brackets are balanced.That means after every closing bracket should follow an opening one.Nested parentheses are not valid, and if two consecutive opening brackets exist, the expression should be marked as unbalanced.
            //Input
            //•	On the first line, you will receive n – the number of lines, which will follow
            ////•	On the next n lines, you will receive "(", ")" or another string
            //Output
            //You have to print "BALANCED", if the parentheses are balanced and "UNBALANCED" otherwise.
            //Constraints
            //•	n will be in the interval[1…20]
            //•	The length of the stings will be between[1…100] characters

            long numberOfLines = long.Parse(Console.ReadLine());
            long opens = 0;
            long closes = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                string line = Console.ReadLine();
                if (line == "(")
                {
                    opens++;
                }
                else if (line == ")")
                {
                    closes++;
                    if (opens - closes != 0)
                    {
                        Console.WriteLine($"UNBALANCED");
                        return;
                    }
                }
            }
            if (opens == closes)
            {
                Console.WriteLine($"BALANCED");
            }
            else
            {
                Console.WriteLine($"UNBALANCED");
            }

        }
    }
}
