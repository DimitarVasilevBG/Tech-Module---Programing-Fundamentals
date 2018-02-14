using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            int zeroes = 0;
            while(result%10==0)
            {
                result /= 10;
                zeroes += 1;
            }
            Console.WriteLine(zeroes);
        }
    }
}
