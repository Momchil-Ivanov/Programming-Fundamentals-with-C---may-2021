using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Write a method that calculates the total price of an order and prints it on the console.The method should receive one of the following products: coffee, coke, water, snacks; and a quantity of the product. The prices for a single piece of each product are: 
            //•	coffee – 1.50
            //•	water – 1.00
            //•	coke – 1.40
            //•	snacks – 2.00
            //Print the result formatted to the second decimal place

            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            priceCalculator(product, quantity);
        }

        static void priceCalculator(string product, int quantity)
        {
            if (product == "coffee")
            {
                double price = quantity * 1.5;
                Console.WriteLine($"{price:f2}");
            }
            if (product == "water")
            {
                double price = quantity * 1;
                Console.WriteLine($"{price:f2}");
            }
            if (product == "coke")
            {
                double price = quantity * 1.4;
                Console.WriteLine($"{price:f2}");
            }
            if (product == "snacks")
            {
                double price = quantity * 2;
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
