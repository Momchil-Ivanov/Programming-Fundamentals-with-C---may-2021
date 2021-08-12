using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            int dataCount = data.Count();
            bool exist = false;

            while (input != "Craft!")
            {
                dataCount = data.Count();
                List<string> currentItem = input.Split(" - ").ToList();
                if (currentItem[0]=="Collect")
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i] == currentItem[1])
                        {
                            exist = true;
                        }
                    }
                    if (!exist)
                    {
                        data.Add(currentItem[1]);
                    }
                    exist = false;
                }
                if (currentItem[0] == "Drop")
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i] == currentItem[1])
                        {
                            data.RemoveAt(i);
                        }
                    }
                }
                if (currentItem[0] == "Combine Items")
                {
                    List<string> pairedItem = currentItem[1].Split(":").ToList();
                    for (int i = 0; i < dataCount; i++)
                    {
                        if (pairedItem[0] == data[i])
                        {
                            data.Insert(i+1, pairedItem[1]);
                        }
                    }
                }
                if (currentItem[0] == "Renew")
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (currentItem[1] == data[i])
                        {
                            string item = currentItem[1];
                            data.RemoveAt(i);
                            data.Add(item);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", data));
        }
    }
}
