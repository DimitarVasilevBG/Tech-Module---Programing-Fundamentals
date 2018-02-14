using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());
            for (char i = ch1; i <= ch2; i++)
            {
                for (char o = ch1; o <= ch2; o++)
                {
                    for (char c = ch1; c <= ch2; c++)
                    {
                        string str = i.ToString() + o.ToString() + c.ToString();
                        if(str.Contains(ch3))
                        {

                        }
                        else
                        Console.Write(str+" ");
                    }
                }
            }

        }
    }
}
