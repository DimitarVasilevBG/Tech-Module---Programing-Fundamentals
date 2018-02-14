using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inp1 = int.Parse(Console.ReadLine());
            int inp2 = int.Parse(Console.ReadLine());
            int start = Math.Min(inp1, inp2);
            int end = Math.Max(inp1, inp2);
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
