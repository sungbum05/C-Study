using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_2501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int p = input[0];

            List<int> output = new List<int>();

            for (int i = 1; i <= p; i++)
            {
                if(p % i == 0)
                    output.Add(i);
            }

            if (output.Count <= input[1] - 1)
            {
                Console.WriteLine(0);
            }

            else
            {
                Console.WriteLine(output[input[1] - 1]);
            }
        }
    }
}
