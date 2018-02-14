using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void GetMax()
        {
            List<double> nums = new List<double>();
            for (int i = 0; i < 3; i++)
            {
                nums.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine(nums.Max());
        }
        static void Main(string[] args)
        {
            GetMax();
        }
    }
}
