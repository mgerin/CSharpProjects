using System;
using System.Linq;

namespace _04.ArrayModifier
{
    class ArrayModifier
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long[] arr = input.Split().Select(n => Convert.ToInt64(n)).ToArray();

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] command = commands.Split();
                if (command[0] == "swap")
                {
                    int indexOne = int.Parse(command[1]);
                    int indexTwo = int.Parse(command[2]);
                    long temp = arr[indexTwo];
                    arr[indexTwo] = arr[indexOne];
                    arr[indexOne] = temp;
                }
                else if (command[0] == "multiply")
                {
                    int indexOne = int.Parse(command[1]);
                    int indexTwo = int.Parse(command[2]);
                    
                    arr[indexOne] = arr[indexOne] * arr[indexTwo];
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--;
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
