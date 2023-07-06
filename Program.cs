using System;

namespace HomeWork_4
{
    /// <summary>
    /// Randomize numbers in 2 arrays.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rand = new Random();
            int[] x1 = new int[20];
            for (int i = 0; i < x1.Length; i++)
            {
                x1[i] = rand.Next(0, 27);
                if (x1[i] % 2 == 0)
                {
                    Console.WriteLine(x1[i]);
                }
            }

            Console.WriteLine("-----------------------------------------------");
            for (int g = 0; g < x1.Length; g++)
            {
                x1[g] = rand.Next(0, 27);
                if (x1[g] % 2 == 1)
                {
                    Console.WriteLine(x1[g]);
                }
            }
        }
    }
}