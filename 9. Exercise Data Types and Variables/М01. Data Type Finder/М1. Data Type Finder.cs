using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            //            You will receive an input until you receive "END".Find what data type is the input. Possible data types are:
            //•	Integer
            //•	Floating point 
            //•	Characters
            //•	Boolean
            //•	Strings
            //Print the result in the following format: "{input} is {data type} type"


            string o = Console.ReadLine();

            while (o != "END")
            {
                string finalType = "String";
                if (!string.IsNullOrEmpty(o))
                {
                    // Check integer before Decimal
                    int tryInt;
                    float tryFloat;
                    bool tryBool;
                    char tryChar;
                    if (Int32.TryParse(o, out tryInt))
                    {
                        finalType = "Integer";
                        Console.WriteLine($"{o} is integer type");
                    }

                    else if (System.Single.TryParse(o, out tryFloat))
                    {
                        finalType = "Float";
                        Console.WriteLine($"{o} is floating point type");
                    }
                    else if (Boolean.TryParse(o, out tryBool))
                    {
                        finalType = "Bool";
                        Console.WriteLine($"{o} is boolean type");
                    }
                    else if (Char.TryParse(o, out tryChar))
                    {
                        finalType = "Char";
                        Console.WriteLine($"{o} is character type");
                    }
                    else
                    {
                        finalType = "String";
                        Console.WriteLine($"{o} is string type");
                    }
                    o = Console.ReadLine();
                }
            }
        }

    }
}

