using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int StickLength = 64;

            int ToStickLength = int.Parse(Console.ReadLine());
            int CurStickLength = StickLength;

            List<int> HalfStick = new List<int>();
            HalfStick.Add(StickLength);
            int CurFloor = 0;

            while(CurStickLength != ToStickLength)
            {
                HalfStick[CurFloor] /= 2;
                HalfStick.Add(HalfStick[CurFloor]);

                if (ToStickLength <= CurStickLength - HalfStick[CurFloor])
                {
                    HalfStick.RemoveAt(CurFloor + 1);
                    CurStickLength -= HalfStick[CurFloor];
                }

                else
                {
                    CurFloor = HalfStick.Count - 1;
                }
            }

            Console.WriteLine(HalfStick.Count);
        }
    }
}
