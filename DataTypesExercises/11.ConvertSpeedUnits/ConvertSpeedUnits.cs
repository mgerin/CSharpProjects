using System;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float timeInHours = (hours + minutes / 60.0f) + (seconds / 3600.0f);

            float kilometersPerHour = (distance / 1000) / timeInHours;
            float metersPerSecond = kilometersPerHour / 3.6f;
            float milesPerHour = (distance / 1609) / timeInHours;

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
