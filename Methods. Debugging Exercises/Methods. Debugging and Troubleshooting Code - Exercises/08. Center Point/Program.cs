using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void CloserPoint(double X1,double Y1,double X2,double Y2)
        {

            if(Math.Abs(X1 - 0) == Math.Abs(X2 - 0) && Math.Abs(Y1 - 0) == Math.Abs(Y2 - 0))
            {
                Console.WriteLine("({0}, {1})",X1,Y1);
            }
            else if (Math.Abs(X1 - 0) < Math.Abs(X2 - 0) && Math.Abs(Y1 - 0) < Math.Abs(Y2 - 0))
            {
                Console.WriteLine("({0}, {1})",X1,Y1);
            }
            else 
            {
                Console.WriteLine("({0}, {1})", X2, Y2);
            }
            

        }
        static void Main(string[] args)
        {
            
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());
            CloserPoint(X1, Y1, X2, Y2);


        }
    }
}
