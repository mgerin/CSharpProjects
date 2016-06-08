using System;

namespace _18.HelloName_
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
