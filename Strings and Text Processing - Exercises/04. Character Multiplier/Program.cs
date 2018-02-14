using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string one = input[0];
            string two = input[1];
            int diff = one.Length - two.Length;
            string substring = "";
            double result = 0;
            for (int i = 0; i < Math.Min(one.Length,two.Length); i++)
            {
                result += (int)(one[i]) * (int)(two[i]);
            }
            if(diff>0)
            {
                substring = one.Substring(two.Length, one.Length-two.Length);
            }
            else if(diff<0)
            {
                substring = two.Substring(one.Length, two.Length-one.Length);
            }
            
            if(diff==0)
                Console.WriteLine(result);
            else
            {
                foreach (var item in substring)
                {
                    result += (int)(item);
                }
                Console.WriteLine(result);
            }
        }
    }
}
