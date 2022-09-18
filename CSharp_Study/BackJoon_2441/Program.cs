using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_2441
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i > j)
                        sb.Append(" ");

                    else
                        sb.Append("*");
                }
                sb.AppendLine(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
