using System;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            string article = Console.ReadLine();
            string content = Console.ReadLine();
            string comment = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {article}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");

            while (comment != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comment}");
                Console.WriteLine("</div>");
                comment = Console.ReadLine();
            }
        }
    }
}
