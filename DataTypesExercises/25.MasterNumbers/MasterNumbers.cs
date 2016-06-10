using System;

namespace _25.MasterNumbers
{
    class MasterNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int num)
        {
            string strNum = num.ToString();
            for (int i = 0; i < strNum.Length; i++)
            {
                if (strNum[i] % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num%10;
                num = num/10;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsPalindrome(int num)
        {
            string stringNum = num.ToString();
            for (int i = 0; i < stringNum.Length; i++)
            {
                if (stringNum[i] != stringNum[stringNum.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
