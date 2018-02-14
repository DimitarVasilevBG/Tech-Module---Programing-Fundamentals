using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Reverse(double number, string copy)
        {
            string result = "";
            for (int i = copy.Length; i>0;i-- )
            {
                result += copy.Last();

                copy = copy.Remove(copy.Length - 1);


            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string str = num.ToString();
            Reverse(num, str);

        }
    }
}
