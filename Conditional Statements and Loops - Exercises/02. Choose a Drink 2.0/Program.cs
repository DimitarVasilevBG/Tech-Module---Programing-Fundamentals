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
            int amount = int.Parse(Console.ReadLine());
            if (proff == "Athlete")
                Console.WriteLine("The Athlete has to pay {0:F2}.",amount*0.70);
            else if (proff == "Businessman" || proff == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.",proff, amount * 1.00);
            }
            else if (proff == "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1:F2}.", proff, amount * 1.70);
            }
            else
                Console.WriteLine("The {0} has to pay {1:F2}.", proff, amount * 1.20);
        }
    }
}
