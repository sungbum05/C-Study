using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            StringBuilder sb = new StringBuilder();

            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int n = num[0];
            int k = num[1];

            int under = 0;
            int turn = under;

            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            while (list != null)
            {
                if (++turn == k)
                {
                    Console.WriteLine(list[turn-1]);
                    list.RemoveAt(turn-1);

                    turn = under;
                }
            }
        } 
    }
}
