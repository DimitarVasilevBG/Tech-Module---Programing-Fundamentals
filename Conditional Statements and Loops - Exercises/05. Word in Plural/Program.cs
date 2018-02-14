using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if(str.Last()=='y')
            {
                str = str.Remove(str.Length-1);
                Console.WriteLine(str+"ies");
            }
            else if (str.Last() == 'o' || str.Last() == 's' || str.Last() == 'x' || str.Last() == 'z')
            {
                Console.WriteLine(str + "es");
            }
            else if (str.Substring(str.Length-2) == "ch")
            {
                Console.WriteLine(str + "es");
            }
            else if (str.Substring(str.Length - 2) == "sh")
            {
                Console.WriteLine(str + "es");
            }
            else
                Console.WriteLine(str + "s");
        }
    }
}
