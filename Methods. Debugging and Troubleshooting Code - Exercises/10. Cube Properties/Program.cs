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
            double SideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            if (parameter == "face")
                PrintFaceOfCube(SideOfCube);
            else if (parameter == "volume")
                PrintVolumeOfCube(SideOfCube);
            else if (parameter == "space")
                PrintSpaceOfCube(SideOfCube);
            else if (parameter == "area")
                PrintAreaOfCube(SideOfCube);

        }

        static void PrintAreaOfCube(double sideOfCube)
        {
            Console.WriteLine("{0:F2}",6*Math.Pow(sideOfCube,2));
        }

        static void PrintSpaceOfCube(double sideOfCube)
        {
            double result = Math.Sqrt(3 * (Math.Pow(sideOfCube, 2)));
            Console.WriteLine("{0:F2}", result);
        }

        static void PrintVolumeOfCube(double sideOfCube)
        {
            Console.WriteLine("{0:F2}",Math.Pow(sideOfCube,3));
        }

        static void PrintFaceOfCube(double sideOfCube)
        {
            double result = Math.Sqrt(2 * (Math.Pow(sideOfCube, 2)));
            Console.WriteLine("{0:F2}",result);
        }
    }
}
