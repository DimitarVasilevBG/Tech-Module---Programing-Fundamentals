using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double discount = 0;
            double price = 0;
            if (package == "Normal")
            {
                discount = 0.05;
                price += 500;
            }
            else if (package == "Gold")
            {
                discount = 0.10;
                price += 750;
            }
            else if (package == "Platinum")
            {
                discount = 0.15;
                price += 1000;
            }
            if(size >0 && size <=50)
            {
                price += 2500;
                Console.WriteLine("We can offer you the Small Hall " + Environment.NewLine + "The price per person is {0:F2}$", (price - (price*discount))/size);
            }
            else if (size > 50 && size <= 100)
            {
                price += 5000;
                Console.WriteLine("We can offer you the Terrace " + Environment.NewLine + "The price per person is {0:F2}$", (price - (price * discount)) / size);
            }
            else if (size > 100 && size <= 120)
            {
                price += 7500;
                Console.WriteLine("We can offer you the Great Hall " + Environment.NewLine+ "The price per person is {0:F2}$", (price - (price * discount)) / size);
            }
            else
                Console.WriteLine("We do not have an appropriate hall.");

        }
    }
}
