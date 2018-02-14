using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDMG = int.Parse(Console.ReadLine());
            int GoshoDMG = int.Parse(Console.ReadLine());
            int PeshoHP = 100;
            int GoshoHP = 100;
            for (int i = 1; true; i++)
            {
                if(i%2!=0)
                {
                    GoshoHP -= PeshoDMG;
                    if (GoshoHP <= 0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.",i);
                        break;
                    }
                    else
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GoshoHP);
                }
                if (i % 2 == 0)
                {
                    PeshoHP -= GoshoDMG;
                    if (PeshoHP <= 0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", i);
                        break;
                    }
                    else
                        Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", PeshoHP);
                    
                }
                if (i % 3 == 0)
                {
                    GoshoHP += 10;
                    PeshoHP += 10;
                }
            }
            


        }
    }
}
