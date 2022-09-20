using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_1331_Silver5_
{
    //미완료 문제

    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Eng = { 'A', 'B', 'C', 'D', 'E', 'F' };
            int[] Num = { 1, 2, 3, 4, 5, 6 };

            string FirstKey = null;
            string FinallyKey = null;

            Dictionary<string, bool> CheckPan = new Dictionary<string, bool>();

            for (int i = 0; i < Eng.Length; i++)
            {
                for (int j = 0; j < Num.Length; j++)
                {
                    CheckPan.Add($"{Eng[i]}{Num[j]}", false);
                }
            }

            for (int i = 0; i < 36; i++)
            {
                if(i == 0)
                {
                    FirstKey = CheckPan[Console.ReadLine()].ToString();
                }

                else if(i == 35)
                {
                    FinallyKey = CheckPan[Console.ReadLine()].ToString();
                }

                CheckPan[Console.ReadLine()] = true;
            }

            Console.WriteLine(FirstKey);
            Console.WriteLine(FinallyKey);

            if (CheckPan.ContainsValue(false))
                Console.WriteLine("Invalid");

            else
                Console.WriteLine("Valid");

            //foreach (KeyValuePair<string, bool> pair in CheckPan)
            //{
            //    Console.WriteLine($"{pair.Key} {pair.Value}");
            //}
        }
    }
}
