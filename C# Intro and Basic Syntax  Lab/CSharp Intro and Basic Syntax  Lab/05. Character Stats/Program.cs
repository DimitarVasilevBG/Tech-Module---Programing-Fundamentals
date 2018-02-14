using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currEP = int.Parse(Console.ReadLine());
            int maxEP = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: "+name);
            Console.Write("Health: ");
            for (int i = 0; i <= currHP; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < maxHP-currHP; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
            Console.Write("Energy: ");
            for (int i = 0; i <= currEP; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < maxEP - currEP; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
        }
    }
}
