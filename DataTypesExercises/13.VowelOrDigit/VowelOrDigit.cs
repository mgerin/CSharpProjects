﻿using System;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5'
                || symbol == '6' || symbol == '7' || symbol == '8' || symbol == '9' || symbol == '0')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
