using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            foreach (var item in input)
            {
                Console.WriteLine("{0} -> {1}",item,Array.IndexOf(alphabet,item));
            }


        }
    }
}
