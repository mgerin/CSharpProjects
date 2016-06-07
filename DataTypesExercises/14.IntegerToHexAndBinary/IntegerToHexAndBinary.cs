using System;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(number,16).ToUpper();
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}
