using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        public static bool IsPrime(double num)
        {
            if (num < 2) return false;

            double newnum = Math.Floor(Math.Sqrt(num));

            for (double i = 2; i <= newnum; i++)
                if (num % i == 0) return false;

            return true;
        }

    }
}
