using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                for (int o = 1; o <= i; o++)
                {
                    if (o != 1 && o != i && i % o == 0)
                        break;
                    else if(o==i)
                        Console.Write(i+" ");
                }
            }
        }
    }
}
