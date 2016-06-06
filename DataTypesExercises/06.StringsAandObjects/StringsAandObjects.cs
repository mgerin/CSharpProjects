using System;

namespace _06.StringsAandObjects
{
    class StringsAandObjects
    {
        static void Main()
        {
            string firstString = "Hello";
            string secondString = "World";
            object obj = firstString + ' ' + secondString;
            string output = (string) obj;
            Console.WriteLine(output);
        }
    }
}
