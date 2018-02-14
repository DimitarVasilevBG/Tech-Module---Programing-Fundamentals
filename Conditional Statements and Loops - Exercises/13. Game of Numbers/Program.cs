using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicN = int.Parse(Console.ReadLine());
            int counter = 0;
            double result = 0;
            int checker = 0;
            string res = "";
            for (int i = start; i <= end; i++)
            {
                for (int o = start; o <= end; o++)
                {
                    if (i + o == magicN)
                    {
                        checker++;
                        res = $"{i} + {o}";
                        break;
                    }
                    counter++;
                    result += 3 * (i * o);

                }
            }

            if(checker>0)
            {
                Console.WriteLine($"Number found! {res} = {magicN}");
            }
            else
                Console.WriteLine($"{counter} combinations - neither equals {magicN}");

        }
    }
}
