using System;
using System.Numerics;

namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            long days = (long)(years*365.2422);
            long hours = days*24;
            ulong minutes = (ulong) (hours*60);
            BigInteger seconds = minutes*60;
            BigInteger miliseconds = seconds*1000;
            BigInteger microseconds = miliseconds*1000;
            BigInteger nanoseconds = microseconds*1000;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", 
                centuries, years, days, hours, minutes, seconds, miliseconds, microseconds, nanoseconds);
        }
    }
}
