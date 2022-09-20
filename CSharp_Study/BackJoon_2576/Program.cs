using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_2576
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();

            int Hap = 0;

            for (int i = 0; i < 7; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a % 2 != 0)
                {
                    input.Add(a);
                }
            }

            if(input.Count == 0)
            {
                Console.WriteLine(-1);
                return;
            }    

            foreach (var item in input)
            {
                Hap += item;
            }

            Console.WriteLine(Hap);
            Console.WriteLine(input.Min());
        }
    }
}
