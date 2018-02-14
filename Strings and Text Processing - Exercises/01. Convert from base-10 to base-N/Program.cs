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
            string result = string.Empty;
            BigInteger N = nums[0];
            BigInteger number = nums[1];
            BigInteger reminder = 0;
            while (number>0 && N>=2 && N<=10)
            {
                reminder = number % N;
                number /= N;
                result = reminder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
