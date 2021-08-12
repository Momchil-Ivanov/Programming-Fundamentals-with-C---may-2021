using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (array.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int indexValueFirst = array[0];
                    sum += indexValueFirst;
                    array[0] = array[array.Count - 1];
                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] <= indexValueFirst)
                        {
                            array[i] += indexValueFirst;
                        }
                        else
                        {
                            array[i] -= indexValueFirst;
                        }
                    }
                    continue;

                }

                else if (index > array.Count - 1)
                {
                    int indexValueLast = array[array.Count - 1];
                    sum += indexValueLast;

                    array[array.Count - 1] = array[0];
                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] <= indexValueLast)
                        {
                            array[i] += indexValueLast;
                        }
                        else
                        {
                            array[i] -= indexValueLast;
                        }
                    }
                    continue;
                }


                int indexValue = array[index];
                sum += array[index];
                array.RemoveAt(index);

                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] <= indexValue)
                    {
                        array[i] += indexValue;
                    }
                    else
                    {
                        array[i] -= indexValue;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
