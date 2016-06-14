using System;

namespace Trifon
{
    class Trifon
    {
        static void Main()
        {
            long health = long.Parse(Console.ReadLine());
            string[] dimensions = Console.ReadLine().Split();
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            char[,] matrix = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string values = Console.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = values[j];
                }
            }
            long turns = 0;
            for (int i = 0; i < cols; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        switch (matrix[j, i])
                        {
                            case 'F':
                                health -= turns / 2;
                                break;
                            case 'H':
                                health += turns / 3;
                                break;
                            case 'E':
                                turns++;
                                continue;
                            case 'T':
                                turns += 2;
                                break;
                        }
                        if (health <= 0)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", j, i);
                            break;
                        }
                        turns++;
                    }
                }
                else
                {
                    for (int j = rows - 1; j >= 0; j--)
                    {
                        switch (matrix[j, i])
                        {
                            case 'F':
                                health -= turns / 2;
                                break;
                            case 'H':
                                health += turns / 3;
                                break;
                            case 'E':
                                turns++;
                                continue;
                            case 'T':
                                turns += 2;
                                break;
                        }
                        if (health <= 0)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", j, i);
                            break;
                        }
                        turns++;
                    }
                }


            }

            if (health > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine("Health: {0}", health);
                Console.WriteLine("Turns: {0}", turns);
            }
        }
    }
}
