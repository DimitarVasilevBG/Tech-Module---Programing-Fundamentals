using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arg = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int skip = arg[0];
            int take = arg[1];
            string pattern = @"(?<=\|<.{" + skip + "})([^|]{0," + take + "})";
            string text = Console.ReadLine();
            List<string> result = new List<string>();
            foreach (Match sentence in Regex.Matches(text,pattern))
            {
                result.Add(sentence.ToString());
            }
            Console.WriteLine(string.Join(", ",result));


        }
    }
}
