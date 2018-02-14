using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int OrdersCount = int.Parse(Console.ReadLine());
            decimal total = 0;
            List<string> result = new List<string>();
            for (int i = 0; i < OrdersCount; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime OrderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());
                decimal math = (DateTime.DaysInMonth(OrderDate.Year, OrderDate.Month)) * capsulesCount * price;
                result.Add(($"The price for the coffee is: ${math:F2}"));
                total += math;
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total: ${0:F2}",total);
        }
    }
}
