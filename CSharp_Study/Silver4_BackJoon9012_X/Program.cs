using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silver4_BackJoon9012_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int cnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < cnt; i++)
            {
                string input = Console.ReadLine();
                bool Check = true;

                foreach (var item in input)
                {
                    switch(item)
                    {
                        case '(':
                            stack.Push(i);
                            break;

                        case ')':
                            if(stack.Count <= 0)
                            {
                                Check = false;
                                break;
                            }

                            else
                                stack.Pop();
                            break;
                    }
                }

                if (Check == false || stack.Count > 0)
                {
                    Console.WriteLine("NO");
                    stack.Clear();
                }

                else
                    Console.WriteLine("YES");
            }
        }
    }
}
