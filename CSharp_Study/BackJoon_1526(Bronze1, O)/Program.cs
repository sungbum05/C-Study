using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_1526_Bronze1__O_
{

    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[2] { '4', '7' };
            int Max = 0;

            int Cnt = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Cnt; i++)
            {
                string input = i.ToString();
                foreach (var item in input)
                {
                    chars.Contains<char>(item);
                }
            }
        }
    }
}
