using System;
using System.Collections.Generic;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split();

                int serial = int.Parse(tokens[0]);
                string name = tokens[1];
                int quantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);
                double totalPrice = itemPrice * quantity;

                Box box = new Box()
                {
                    Serial = serial,
                    Name = name,
                    Quantity = quantity,
                    ItemPrice = itemPrice,
                    TotalPrice = totalPrice
                };

                boxes.Add(box);
                line = Console.ReadLine();
            }

            boxes.Sort((s1, s2) => s2.TotalPrice.CompareTo(s1.TotalPrice));
            foreach (Box box in boxes)
            {

                Console.WriteLine($"{box.Serial}");
                Console.WriteLine($"-- {box.Name} - ${box.ItemPrice:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");
            }

        }
    }



    class Box
    {
        public int Serial { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }

        public double TotalPrice { get; set; }
    }
}

