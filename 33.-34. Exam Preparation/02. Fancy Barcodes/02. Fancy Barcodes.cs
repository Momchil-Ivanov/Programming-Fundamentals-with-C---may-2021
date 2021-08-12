using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "@[#]+[A-Z]{1,1}[A-Za-z0-9]{4,}[A-Z]{1,1}@[#]+";

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                Match m = Regex.Match(input, pattern);

                if (m.Success)
                {
                    string numberPattern = "[0-9]+";
                    bool defaultGroup = true;
                    string productGroup = string.Empty;

                    Regex rgx = new Regex(numberPattern);
                    MatchCollection matches = rgx.Matches(input);
                    foreach (Match match in matches)
                    {
                        productGroup += match;
                        defaultGroup = false;
                    }
          
                    if (defaultGroup == true)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid barcode"); 
                }
            }
        }
    }
}
