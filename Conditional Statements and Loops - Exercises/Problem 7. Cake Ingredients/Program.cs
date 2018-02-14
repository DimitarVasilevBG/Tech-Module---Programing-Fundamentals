using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;true ; i++)
            {
                string ingr = Console.ReadLine();
                if (ingr != "Bake!")
                    Console.WriteLine("Adding ingredient {0}.", ingr);
                else if (ingr == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.",i);
                    break;
                }
            }


        }
    }
}
