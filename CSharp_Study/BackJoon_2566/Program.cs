using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_2566
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Pan = new int[9, 9];
            int[] a = new int[9];

            int max = 0;
            int x = 0, y = 0;

            for (int i = 0; i < Pan.GetLength(0); i++)
            {
                a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                for (int j = 0; j < Pan.GetLength(1); j++)
                {
                    Pan[i, j] = a[j];
                }
            }

            for (int i = 0; i < Pan.GetLength(0); i++)
            {
                for (int j = 0; j < Pan.GetLength(1); j++)
                {
                    if(Pan[i, j] > max)
                    {
                        max = Pan[i, j];
                        x = i;
                        y = j;
                    }
                }
            }

            Console.WriteLine($"{max}\n{x + 1} {y + 1}");
        }
    }
}
