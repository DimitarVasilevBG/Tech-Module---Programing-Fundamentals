using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            
            if (Math.Abs(start - end) > 4)
            {
                for (int a = start; a <= end; a++)
                {
                    for (int b = start; b <= end; b++)
                    {
                        for (int c = start; c <= end; c++)
                        {

                            for (int d = start; d <= end; d++)
                            {

                                for (int e = start; e <= end; e++)
                                {
                                    if(a < b && b < c && c < d && d < e)
                                        Console.WriteLine("{0} {1} {2} {3} {4}",a,b,c,d,e);
                                }
                            }
                        }
                    }
                }
            }
            else
                Console.WriteLine("No");
            
        }
    }
}
