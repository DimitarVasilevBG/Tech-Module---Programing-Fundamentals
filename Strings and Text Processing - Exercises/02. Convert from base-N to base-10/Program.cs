using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger[] nums = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger result = 0;
            BigInteger N = nums[0];
            BigInteger number = nums[1];
            BigInteger multiplied = 0;
            int count = number.ToString().Length;
            for (int i = 0; i <= count; i++)
            {
                multiplied = number % 10 * BigInteger.Pow(N,i);
                number /= 10;
                result = result + multiplied;
            
            }
                
            Console.WriteLine(result);
        }
    }
}
