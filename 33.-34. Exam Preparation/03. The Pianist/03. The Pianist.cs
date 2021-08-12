using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, string> piecesComposers = new Dictionary<string, string>();
            Dictionary<string, string> piecesKeys = new Dictionary<string, string>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] piece = Console.ReadLine().Split("|").ToArray();

                if (piecesComposers.ContainsKey(piece[0]))
                {
                    break;
                }

                piecesComposers.Add(piece[0], piece[1]);
                piecesKeys.Add(piece[0], piece[2]);
            }

            string[] command = Console.ReadLine().Split("|").ToArray();

            while (command[0] != "Stop")
            {
                if (command[0] == "Add")
                {
                    string piece = command[1];
                    string composer = command[2];
                    string key = command[3];

                    if (piecesComposers.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                        command = Console.ReadLine().Split("|").ToArray();
                        continue;
                    }
                    else
                    {
                        piecesComposers.Add(piece, composer);
                        piecesKeys.Add(piece, key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }

                else if (command[0] == "Remove")
                {
                    string piece = command[1];

                    if (!piecesComposers.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        command = Console.ReadLine().Split("|").ToArray();
                        continue;
                    }
                    else
                    {
                        piecesComposers.Remove(piece);
                        piecesKeys.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                }

                else if (command[0] == "ChangeKey")
                {
                    string piece = command[1];
                    string newKey = command[2];

                    if (!piecesComposers.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        command = Console.ReadLine().Split("|").ToArray();
                        continue;
                    }
                    else
                    {
                        piecesKeys[piece] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                }
                command = Console.ReadLine().Split("|").ToArray();
            }

            var ordered = piecesComposers.OrderBy(x => x.Key).ThenBy(y => y.Value).ToDictionary(x => x.Key, y => y.Value);
            
            foreach (var piece in ordered)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {piecesKeys[piece.Key]}");
            }
        }
    }
}
