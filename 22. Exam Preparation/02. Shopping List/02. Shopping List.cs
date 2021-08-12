using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split('!').ToList();
            string input = Console.ReadLine();

            bool existForUrgent = false;
            while (input != "Go Shopping!")
            {
                List<string> partsOfInput = input.Split(' ').ToList();
                if (partsOfInput[0]=="Urgent")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (partsOfInput[1] == list[i])
                        {
                            existForUrgent = true;
                        }
                    }
                    if (!existForUrgent)
                    {
                        list.Insert(0, partsOfInput[1]);
                    }
                    else
                    {
                        existForUrgent = false;
                    }
                }
                if (partsOfInput[0]=="Unnecessary")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (partsOfInput[1]==list[i])
                        {
                            list.RemoveAt(i);
                        }
                    }
                }
                if (partsOfInput[0]== "Correct")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (partsOfInput[1] ==list[i])
                        {
                            list.Insert(i, partsOfInput[2]);
                            list.RemoveAt(i+1);
                        }
                    }
                }
                if (partsOfInput[0]== "Rearrange")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (partsOfInput[1]==list[i])
                        {
                            list.RemoveAt(i);
                            list.Add(partsOfInput[1]);
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", list));
        }
    }
}
