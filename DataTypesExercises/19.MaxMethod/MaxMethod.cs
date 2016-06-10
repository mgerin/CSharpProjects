using System;

namespace _19.MaxMethod
{
    class MaxMethod
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int resultOne = GetMax(a, b);
            int resultTwo = GetMax(resultOne, c);
            Console.WriteLine(resultTwo);
        }

        private static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
