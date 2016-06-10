using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _24.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static List<int> primes = new List<int>();

        static void Main()
        {
            int strartNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            FindPrimesInRange(strartNum, endNum);
            PrintListOfInt(primes);
        }

        private static void PrintListOfInt(List<int> ints)
        {
            string primesList = String.Join(", ", primes);
            Console.WriteLine(primesList);
        }

        private static List<int> FindPrimesInRange(int strartNum, int endNum)
        {
            for (int i = strartNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        private static bool IsPrime(long number)
        {
            int boundary = (int)(Math.Floor(Math.Sqrt(number)));

            if (number == 0 || number == 1)
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
