using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon_1920
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deque = new List<int>();

            StringBuilder sb = new StringBuilder();
            int PlayCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < PlayCnt; i++)
            {
                string[] Command = Console.ReadLine().Split(' ');

                switch (Command[0])
                {
                    case "push_front":
                        push_front(int.Parse(Command[1]));
                        break;

                    case "push_back":
                        push_back(int.Parse(Command[1]));
                        break;

                    case "pop_front":
                        sb.AppendLine($"{pop_front()}");
                        break;

                    case "pop_back":
                        sb.AppendLine($"{pop_back()}");
                        break;

                    case "front":
                        sb.AppendLine($"{front()}");
                        break;

                    case "back":
                        sb.AppendLine($"{back()}");
                        break;

                    case "empty":
                        sb.AppendLine($"{empty()}");
                        break;

                    case "size":
                        sb.AppendLine($"{size()}");
                        break;
                }
            }

            Console.WriteLine(sb.ToString());

            void push_front(int x)
            {
                deque.Insert(0, x);
            }

            void push_back(int x)
            {
                deque.Add(x);
            }

            int pop_front()
            {
                int value = -1;

                if(deque.Count <= 0)
                    return value;

                value = deque[0];
                deque.RemoveAt(0);

                return value;
            }

            int pop_back()
            {
                int value = -1;

                if (deque.Count <= 0)
                    return value;

                value = deque[deque.Count - 1];
                deque.RemoveAt(deque.Count - 1);

                return value;
            }

            int size()
            {
                return deque.Count;
            }

            int empty()
            {
                if(deque.Count <= 0)
                    return 1;

                return 0;
            }

            int front()
            {
                if(deque.Count <= 0)
                    return -1;

                return deque[0];
            }

            int back()
            {
                if (deque.Count <= 0)
                    return -1;

                return deque[deque.Count - 1];
            }
        }
    }
}
