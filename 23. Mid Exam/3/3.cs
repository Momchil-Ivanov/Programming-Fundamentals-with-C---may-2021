using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatHistory = new List<string>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                List<string> partsOfCommand = command.Split(" ").ToList();
                if (partsOfCommand[0] == "Chat")
                {
                    chatHistory.Add(partsOfCommand[1]);
                }
                if (partsOfCommand[0] == "Delete")
                {
                    for (int i = 0; i < chatHistory.Count; i++)
                    {
                        if (chatHistory[i] == partsOfCommand[1])
                        {
                            chatHistory.Remove(partsOfCommand[1]);
                        }
                    }
                }
                if (partsOfCommand[0] == "Edit")
                {
                    for (int i = 0; i < chatHistory.Count; i++)
                    {
                        if (chatHistory[i] == partsOfCommand[1])
                        {
                            chatHistory[i] = partsOfCommand[2];
                        }
                    }
                }
                if (partsOfCommand[0] == "Pin")
                {
                    for (int i = 0; i < chatHistory.Count; i++)
                    {
                        if (chatHistory[i] == partsOfCommand[1])
                        {
                            chatHistory.Add(partsOfCommand[1]);
                            chatHistory.RemoveAt(i);
                        }
                    }
                }
                if (partsOfCommand[0] == "Spam")
                {
                    for (int i = 1; i < partsOfCommand.Count; i++)
                    {
                        chatHistory.Add(partsOfCommand[i]);
                    }
                }
                command = Console.ReadLine();
            }

            for (int i = 0; i < chatHistory.Count; i++)
            {
                Console.WriteLine(chatHistory[i]);
            }
        }
    }
}
