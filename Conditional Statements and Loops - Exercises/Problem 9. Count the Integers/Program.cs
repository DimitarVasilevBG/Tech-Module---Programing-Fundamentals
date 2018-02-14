using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; true; i++)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine(i);
                    break;
                }
            }

        }
    }
}
