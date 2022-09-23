using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silver5_BackJoon11866_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();

            StringBuilder stringBuilder = new StringBuilder();

            int cnt = 0;

            //값 설정
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for (int i = 1; i <= input[0]; i++)
            {
                queue.Enqueue(i);
            }

            stringBuilder.Append("<");

            while(queue.Count > 0 || queue2.Count > 0)
            {
                if(queue.Count == 0 && queue2.Count > 0)
                    queue = queue2;

                cnt++;

                if(cnt % input[1] == 0)
                {
                    stringBuilder.Append($"{queue.Dequeue()}, ");
                }

                else
                {
                    queue2.Enqueue(queue.Dequeue());

                    if(queue.Count <= 0)
                    {
                        queue = queue2;
                    }
                }
            }

            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            stringBuilder.Append(">");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
