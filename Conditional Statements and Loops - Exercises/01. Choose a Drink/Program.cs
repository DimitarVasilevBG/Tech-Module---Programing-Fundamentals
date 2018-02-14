using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {

            string proff = Console.ReadLine();
            if (proff == "Athlete")
                Console.WriteLine("Water");
            else if (proff == "Businessman" || proff == "Businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (proff == "SoftUni Student")
            {
                Console.WriteLine("Beer");
            }
            else
                Console.WriteLine("Tea");
        }
    }
}
