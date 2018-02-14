using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static bool IsPalindome(int num)
        {
            string sNum = num.ToString();
            for (int i = 0; i < sNum.Length / 2; i++)
                if (sNum[i] != sNum[sNum.Length - 1 - i]) return false;

            return true;
        }
        static int SumDiggits(int num)
        {

            int sum = 0;
            foreach (var item in num.ToString())
            {
                int digit = item - '0';
                sum += digit;
            }
            return sum;


        }
        static bool ContainsEven(int num)
        {

                foreach (var item in num.ToString())
                {
                    int digits = item - '0';
                    if (digits % 2 == 0)
                    {
                        return true;
                      
                    }

                }
            return false;

        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<int> palindromes = new List<int>();
            for (int i = 1; i <= input; i++)
            {
                if (IsPalindome(i) && SumDiggits(i) % 7 == 0 && ContainsEven(i))
                    Console.WriteLine(i);
            }
          
        }

       
    }
}
