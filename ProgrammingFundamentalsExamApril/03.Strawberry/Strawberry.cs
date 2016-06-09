using System;

namespace _03.Strawberry
{
    class Strawberry
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number / 2; i++)
            {
                Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-', i * 2), new string('-', number - i * 2));
            }

            int dots = 1;

            for (int i = 0; i < number / 2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-', number - i * 2), new string('.', dots));
                dots += 4;
            }

            int width = number*2 + 3;

            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-', i), new string('.', width - 2 - 2 * i));
            }
        }
    }
}
