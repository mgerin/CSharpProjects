using System;
using System.Linq;

namespace _05.TripleSum
{
    class TripleSum
    {
        static void Main()
        {
            long[] arr = Console.ReadLine().Split(' ').Select(n => long.Parse(n)).ToArray();
            bool isFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    long a = arr[i];
                    long b = arr[j];
                    long sum = a + b;
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        isFound = true;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
