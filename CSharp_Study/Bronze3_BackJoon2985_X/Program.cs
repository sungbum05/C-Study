using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bronze3_BackJoon2985_X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),  int.Parse);

            if(input[0] + input[1] == input[2])
            {
                Console.WriteLine($"{input[0]}+{input[1]}={input[2]}");
            }

            else if (input[0] - input[1] == input[2])
            {
                Console.WriteLine($"{input[0]}-{input[1]}={input[2]}");
            }

            else if (input[0] / input[1] == input[2])
            {
                Console.WriteLine($"{input[0]}/{input[1]}={input[2]}");
            }

            else if (input[0] % input[1] == input[2])
            {
                Console.WriteLine($"{input[0]}%{input[1]}={input[2]}");
            }

            else if (input[1] + input[2] == input[0])
            {
                Console.WriteLine($"{input[2]}={input[1]}+{input[0]}");
            }

            else if (input[1] - input[2] == input[0])
            {
                Console.WriteLine($"{input[2]}={input[1]}-{input[0]}");
            }

            else if (input[1] / input[2] == input[0])
            {
                Console.WriteLine($"{input[2]}={input[1]}/{input[0]}");
            }

            else if (input[1] % input[2] == input[0])
            {
                Console.WriteLine($"{input[2]}%{input[1]}%{input[0]}");
            }
        }
    }
}
