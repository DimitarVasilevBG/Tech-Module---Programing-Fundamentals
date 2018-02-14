using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().ToCharArray();
            foreach (var item in chars)
            {
                Console.Write("\\u" + ((int)item).ToString("x4"));
            }
        }
    }
}
