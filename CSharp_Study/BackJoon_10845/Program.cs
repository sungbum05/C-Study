using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_10845
{
    internal class Program
    {
        const int Bottom = -1;

        public static int[] Queue = new int[1000000];
        public static int CurFloor = -1;

        public static StringBuilder sb = new StringBuilder();
        
        static void Main(string[] args)
        {
            int PlayCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < PlayCnt; i++)
            {
                string[] Command = Console.ReadLine().Split(' ');

                switch (Command[0])
                {
                    case "push":
                        push(int.Parse(Command[1]));
                        break;

                    case "pop":
                        sb.Append($"{pop()}\n");
                        break;

                    case "front":
                        front();
                        break;

                    case "back":
                        back();
                        break;

                    case "empty":
                        empty();
                        break;

                    case "size":
                        size();
                        break;
                }
            }

            Console.WriteLine(sb.ToString());
        }

        public static void push(int value)
        {
            CurFloor++;
            Queue[CurFloor] = value;
        }

        public static int pop()
        {
            if (CurFloor == Bottom)
            {
                return -1;
            }

            int ReturnValue = Queue[Bottom + 1];
            for (int i = 0; i < CurFloor; i++)
            {
                Queue[i] = Queue[i + 1];
            }

            CurFloor--;
            return ReturnValue;
        }

        public static void front()
        {
            if (CurFloor == Bottom)
            {
                sb.Append($"{-1}\n");
                return;
            }

            sb.Append($"{Queue[Bottom + 1]}\n");
        }
        public static void back()
        {
            if (CurFloor == Bottom)
            {
                sb.Append($"{-1}\n");
                return;
            }

            sb.Append($"{Queue[CurFloor]}\n");
        }

        public static void empty()
        {
            int a = CurFloor < 0 ? 1 : 0;
            sb.Append($"{a}\n");
        }

        public static void size()
        {
            sb.Append($"{CurFloor + 1}\n");
        }
    }
}
