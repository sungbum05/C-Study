using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silver4_BackJoon1018_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] Type1 = { 'W', 'B' };
            char[] Type2 = { 'B', 'W' };

            char[] CurType;

            int Type1Cnt = 0;
            int Type2Cnt = 0;

            int[] Cnt = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            char[,] input = new char[Cnt[0],Cnt[1]];
            for (int i = 0; i < Cnt[0]; i++)
            {
                int idx = 0;

                foreach(var item in Console.ReadLine())
                {
                    input[i, idx] = item;
                    idx++;
                }
            }

            for (int i = 0; i < Cnt[0]; i++)
            {
                int ArrCnt = 0;

                if (i % 2 == 0)
                    CurType = Type1;

                else
                    CurType = Type2;

                for (int j = 0; j < Cnt[1]; j++)
                {
                    if (CurType[ArrCnt] != input[i, j])
                    {
                        Type1Cnt++;
                    }

                    ArrCnt++;

                    if (CurType.Length <= ArrCnt)
                    {
                        ArrCnt = 0;
                    }
                }
            }

            for (int i = 0; i < Cnt[0]; i++)
            {
                int ArrCnt = 0;

                if (i % 2 == 0)
                    CurType = Type2;

                else
                    CurType = Type1;

                for (int j = 0; j < Cnt[1]; j++)
                {
                    if (CurType[ArrCnt] != input[i, j])
                    {
                        Type2Cnt++;
                    }

                    ArrCnt++;

                    if (CurType.Length <= ArrCnt)
                    {
                        ArrCnt = 0;
                    }
                }
            }

            Console.WriteLine(Type1Cnt);
            Console.WriteLine(Type2Cnt);
        }
    }
}
