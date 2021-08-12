using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a group of people, type of the group, on which day of the week they are going to stay. Based on that information calculate how much they have to pay and print that price on the console. Use the table below. In each cell is the price for a single person.The output should look like that: “Total price: { price}”. The price should be formatted to the second decimal point.
            //            Friday Saturday    Sunday
            //Students    8.45    9.80    10.46
            //Business    10.90   15.60   16
            //Regular          15  20  22.50
            //There are also discounts based on some conditions:
            //•	Students – if the group is bigger than or equal to 30 people you should reduce the total price by 15 %
            //•	Business – if the group is bigger than or equal to 100 people 10 of them can stay for free.
            //•	Regular – if the group is bigger than or equal to 10 and less than or equal to 20 reduce the total price by 5 %
            //Note: You should reduce the prices in that EXACT order!

            int number = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double sum = 0;

            if (group == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

                sum = price * number;

                if (number>=30)
                {
                    sum *= 0.85;
                }
            }
            else if (group == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
                if (number >= 100)
                {
                    number-=10;
                }

                sum = price * number;

            }
            else if (group == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
                if (number >= 10 && number <=20)
                {
                    price *= 0.95;
                }

                sum = price * number;

            }

            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
