using System;

namespace _02.GameOfNames
{
    class GameOfNames
    {
        static void Main()
        {
            int n = byte.Parse(Console.ReadLine());
            int totalScore = int.MinValue;
            string player = String.Empty;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int score = int.Parse(Console.ReadLine());
                for (int j = 0; j < name.Length; j++)
                {
                    if ((int) name[j] % 2 == 0)
                    {
                        score += (int) name[j];
                    }
                    else
                    {
                        score -= (int) name[j];
                    }
                }

                if (score > totalScore)
                {
                    totalScore = score;
                    player = name;
                }
            }

            Console.WriteLine("The winner is {0} - {1} points", player, totalScore);
        }
    }
}
