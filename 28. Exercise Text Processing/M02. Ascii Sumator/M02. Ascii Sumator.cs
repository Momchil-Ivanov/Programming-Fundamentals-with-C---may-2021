using System;
using System.Text;

namespace M03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string last = Console.ReadLine();

            string s = Console.ReadLine();

            int firstIndexValue = 0;
            int lastIndexValue = 0;

            int sum = 0;

            foreach (char c in first)
            {
                firstIndexValue += c;
            }
            foreach (char c in last)
            {
                lastIndexValue += c;
            }
            foreach (char c in s)
            {
                if (firstIndexValue < lastIndexValue)
                {
                    if ((int)c > firstIndexValue && (int)c < lastIndexValue)
                    {
                        sum += c;
                    }
                }
                else
                {
                    if ((int)c > lastIndexValue && (int)c < firstIndexValue)
                    {
                        sum += (int)c;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
