using System;

namespace _23.PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        private static bool IsPrime(long number)
        {
            int boundary = (int) (Math.Floor(Math.Sqrt(number)));

            if (number == 1 || number == 0)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }

            for (int i = 2; i <= boundary; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
