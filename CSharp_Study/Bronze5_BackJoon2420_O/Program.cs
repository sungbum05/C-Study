using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze5_BackJoon2420_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);

            long a = input[0] - input[1];
             a = Math.Abs(a);

            Console.WriteLine(a);
        }
    }
}
