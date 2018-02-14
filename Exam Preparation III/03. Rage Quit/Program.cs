using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"([\D]+)([0-9]+)";
            MatchCollection strings = Regex.Matches(input, pattern);
            HashSet<string> hash = new HashSet<string>();

            foreach (Match item in strings)
            {
                if (item.Groups[2].ToString() == "0")
                    continue;
                foreach (var symbol in item.Groups[1].ToString())
                {
                    foreach (var ch in symbol.ToString())
                    {
                        hash.Add(ch.ToString());
                    }
                }
            }
            Console.WriteLine("Unique symbols used: {0}", hash.Count);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strings.Count; i++)
            {

                int num = int.Parse(strings[i].Groups[2].ToString());
                for (int o = 0; o < num; o++)
                {
                    sb.Append(strings[i].Groups[1]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
