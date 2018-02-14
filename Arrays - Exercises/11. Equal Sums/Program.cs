using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double leftsum = 0;
            double rightsum = 0;
            bool find = false;
            if(numbers.Length < 2)
                Console.WriteLine("0");
            else
            {
                for (int i = 0; i <= numbers.Length-1; i++)
                {
                    for (int l = 0 ; l < i; l++)
                    {
                        leftsum += numbers[l];
                    }
                    for (int r = i+1; r < numbers.Length; r++)
                    {
                        rightsum += numbers[r];
                    }
                    if(leftsum==rightsum)
                    {
                        find = true;
                        Console.WriteLine(i);
                        break;
                    }
                    else
                    {
                        leftsum = 0;
                        rightsum = 0;
                    }
                }

                if (!find)
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
