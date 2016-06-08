using System;

namespace _01.SweetDessert
{
    class SweetDessert
    {
        static void Main()
        {
            double cash = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananasPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            int sets = guests / 6;
            if (guests % 6 != 0)
            {
                sets++;
            }

            double productPrice = sets * (2 * bananasPrice + 4 * eggsPrice + 0.20 * berriesPrice);

            if (cash >= productPrice)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", productPrice);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", productPrice - cash);
            }
        }
    }
}
