using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static bool IsPrime(int start, int end)
        {
            List<int> nums = new List<int>();
            for (int i = start; i <= end; i++)
            {
                for (int o = 2; o <= i; o++)
                {
                    if (i % o == 0 && o != i)
                    {
                        break;
                    }
                    else if(o==i)
                    {
                        nums.Add(i);
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",nums));
            return true;
        }
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            IsPrime(start, end);




        }
    }
}
