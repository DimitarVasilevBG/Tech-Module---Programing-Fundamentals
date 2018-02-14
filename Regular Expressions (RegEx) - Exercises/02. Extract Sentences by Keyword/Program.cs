using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string split = @"[?.!]";
            string[] result = Regex.Split(text, split);
            string pattern = "\\b" + keyword + "\\b";
            Regex regex = new Regex(pattern);
            foreach (var item in result)
            {
                if(regex.IsMatch(item))
                Console.WriteLine(item.Trim());
            }

        }
    }
}
