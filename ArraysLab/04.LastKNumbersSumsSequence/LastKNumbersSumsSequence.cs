﻿using System;

namespace _04.LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] seq = new long[n];
            seq[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long result = 0;
                for (int j = i - 1; j >= 0 && j >= i - k; j--)
                {
                    result += seq[j];
                }
                seq[i] = result;
            }

            Console.WriteLine(String.Join(" ", seq));
        }
    }
}
