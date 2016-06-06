using System;

namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool output = Convert.ToBoolean(input);

            if (output)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
