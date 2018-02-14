using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {

        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
                AreaOfTriangle();
            else if (figure == "square")
                AreaOfSquare();
            else if (figure == "rectangle")
                AreaOfRectangle();
            else if (figure == "circle")
                AreaOfCirle();

        }

        static void AreaOfTriangle()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",(side * height) /2);
        }

        static void AreaOfSquare()
        {
            double side = double.Parse(Console.ReadLine());
          
            Console.WriteLine("{0:F2}",side * side);
        }

        static void AreaOfRectangle()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",width * height);
        }

        static void AreaOfCirle()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", Math.PI*(radius*radius));
        }
    }
}
