using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            string pattern = @"([\w.-]+\@[a-zA-z]+)(\.[a-zA-Z-]+)+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match m in matches)
            {
                string email = m.ToString();
                if (email.StartsWith(".") || email.StartsWith("-") || email.StartsWith("_") || email.EndsWith(".")||
                    email.EndsWith("-")||email.EndsWith("_"))
                {

                }
                else
                Console.WriteLine(m);
            }
        }
    }
}
