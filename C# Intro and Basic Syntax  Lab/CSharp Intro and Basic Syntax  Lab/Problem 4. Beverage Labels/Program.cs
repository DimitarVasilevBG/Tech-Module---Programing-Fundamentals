using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            double multi = volume / 100;
            Console.WriteLine("{0}ml {1}:",volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars",energy*multi,sugar*multi);
            

        }
    }
}
