using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Until you receive "Start" you will be given different coins that are being inserted in the machine. You have to sum them in order to have the total money inserted.There is a problem though.
            //Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins.If someone tries to insert some other coins you have to display "Cannot accept {money}" and not add it to the total money. 
            //On the next few lines until you receive "End" you will be given products to purchase.Your machine has however only "Nuts", "Water", "Crisps", "Soda", "Coke".The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively.If the person tries to purchase a not existing product print "Invalid product".
            //Be careful that the person may try to purchase a product they don’t have the money for. In that case print "Sorry, not enough money".If the person purchases a product successfully print "Purchased {product name}".
            //After the "End" command print the money that are left formatted to the second decimal point in the format "Change: {money left}".

            string command = Console.ReadLine();
            double money = 0;

            

            while (command != "Start")
            {
                double inputMoney = double.Parse(command);

                if (inputMoney == 0.1 || inputMoney == 0.2|| inputMoney == 0.5||inputMoney==1||inputMoney==2)
                {
                    money += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }


                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Nuts" && money >=2)
                {
                    money -= 2;
                    Console.WriteLine("Purchased nuts");
                }
                else if (command == "Nuts" && money < 2)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (command == "Water" && money >=0.7)
                {
                    money -= 0.7;
                    Console.WriteLine("Purchased water");
                }
                else if (command == "Water" && money < 0.7)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (command == "Crisps" && money>=1.5)
                {
                    money -= 1.5;
                    Console.WriteLine("Purchased crisps");
                }
                else if (command == "Crisps" && money < 1.5)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (command == "Soda" && money>=0.8)
                {
                    money -= 0.8;
                    Console.WriteLine("Purchased soda");
                }
                else if (command == "Soda" && money < 0.8)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (command == "Coke" && money>=1.0)
                {
                    money -= 1.0;
                    Console.WriteLine("Purchased coke");

                }
                else if (command == "Coke" && money < 1.0)
                {
                    money -= 1.0;
                    Console.WriteLine("Sorry, not enough money");

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                command = Console.ReadLine();
            }    

            Console.WriteLine($"Change: {money:f2}");

        }
    }
}
