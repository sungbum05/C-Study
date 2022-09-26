using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze4_BackJoon5596_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputA = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] inputB = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int A = 0;
            int B = 0;

            A = Hap(inputA);
            B = Hap(inputB);

            Console.WriteLine(A > B ? A : B);

            int Hap(int[] Array)
            {
                int hap = 0;

                foreach (var item in Array)
                {
                    hap += item;
                }

                return hap;
            }
        }
    }
}
