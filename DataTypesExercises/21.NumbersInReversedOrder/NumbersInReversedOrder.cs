using System;

namespace _21.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumber(number));
        }

        private static string ReverseNumber(string number)
        {
            string reversedNumber = "";
            int length = number.Length -1;
            while (length>=0)
            {
                reversedNumber = reversedNumber + number[length];
                length--;
            }
            return reversedNumber;
        }
    }
}
