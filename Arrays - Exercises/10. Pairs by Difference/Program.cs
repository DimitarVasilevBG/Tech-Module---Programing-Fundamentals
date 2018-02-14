using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int pairs = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int o = i+1; o < numbers.Length; o++)
                {
                    if (Math.Abs(numbers[i] - numbers[o]) == diff)
                    {
                        pairs++;
                    }
                }
              
            }
            Console.WriteLine(pairs);



        }
    }
}
