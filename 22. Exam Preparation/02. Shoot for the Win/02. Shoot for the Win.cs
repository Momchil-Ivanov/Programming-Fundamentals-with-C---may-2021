using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<int> intOfList = list.Select(x => int.Parse(x)).ToList();

            string targetIndex = Console.ReadLine();
            int countOfShotTargets = 0;

            while (targetIndex != "End")
            {
                int intOfTargetIndex = int.Parse(targetIndex);
                if (intOfTargetIndex>=intOfList.Count)
                {
                    targetIndex = Console.ReadLine();
                    continue;
                }
                if (intOfList[intOfTargetIndex] != -1)
                {
                    countOfShotTargets++;
                    int temporalIntOfList = intOfList[intOfTargetIndex];
                    intOfList[intOfTargetIndex] = -1;
                    for (int i = 0; i < intOfList.Count; i++)
                    {
                        if (intOfList[i] > temporalIntOfList && intOfList[i] != -1)
                        {
                            intOfList[i] -= temporalIntOfList;
                        }
                        else if (intOfList[i] <= temporalIntOfList && intOfList[i] != -1)
                        {
                            intOfList[i] += temporalIntOfList;
                        }
                    }
                }
                targetIndex = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {countOfShotTargets} -> {String.Join(' ', intOfList)}");
        }
    }
}
