using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int counter = 0;
            double result = 0;
            for (int i = start; i >= 1; i--)
            {
                for (int o = 1; o <= end; o++)
                {
                    if (result >= max)
                        break;
                    counter++;
                    result += 3 * (i * o);
                    
                }
            }
            if (result >= max)
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0} >= {1}",result,max);
            }
            else
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", result);
            }
                

        }
    }
}
