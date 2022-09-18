using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_2506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int Score = 0;
            int AddScore = 0;

            for(int i = 0; i < cnt; i++)
            {
                if(input[i] == 0)
                {
                    AddScore = 0;
                }

                else
                {
                    AddScore++;
                    Score += AddScore;
                }
            }

            Console.WriteLine(Score);
        }
    }
}
