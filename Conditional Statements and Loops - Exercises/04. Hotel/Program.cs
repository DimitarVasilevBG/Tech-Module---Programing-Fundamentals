using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double studio = 0;
            double tworoom = 0;
            double suite = 0;
            if (month == "May" || month == "October")
            {
                studio = 50;
                tworoom = 65;
                suite = 75;
                if (nights > 7)
                {
                    studio *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 60;
                tworoom = 72;
                suite = 82;
                if (nights > 14)
                {
                    tworoom *= 0.90;
                }
                
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                tworoom = 77;
                suite = 89;
                if (nights > 14)
                {
                    suite *= 0.85;
                }
            }
            tworoom *= nights;
            suite *= nights;
            if (month == "September" || month == "October")
            {
                if (nights > 7)
                    nights -= 1;
            }
            studio *= nights;
            Console.WriteLine("Studio: {0:F2} lv.",studio);
            Console.WriteLine("Double: {0:F2} lv.",tworoom);
            Console.WriteLine("Suite: {0:F2} lv.",suite);


        }
    }
}
