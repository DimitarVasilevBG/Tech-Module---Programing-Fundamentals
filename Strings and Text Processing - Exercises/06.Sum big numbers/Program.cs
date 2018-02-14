using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
        }
    }
}
