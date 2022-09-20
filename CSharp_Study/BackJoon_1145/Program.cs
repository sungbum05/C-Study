using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_1145
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int num = 0;
            int cnt = 0;

            while(cnt < 3)
            {
                cnt = 0;
                num++;

                foreach (var item in input)
                {
                    if(num % item == 0)
                    {
                        //Console.WriteLine(item);
                        cnt++;
                    }
                }
            }

            Console.WriteLine(num);
        }
    }
}
