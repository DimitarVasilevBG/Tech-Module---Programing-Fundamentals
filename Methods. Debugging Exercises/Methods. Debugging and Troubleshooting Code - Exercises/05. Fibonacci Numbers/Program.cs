using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int first = 0;
            int last = 1;
            int copy = 0;
            for (int i = 0; i < num; i++)
            {
                copy = last;
                last = first + last;
                first = copy;
            
            }
            Console.WriteLine(last);

        }
    }
}
