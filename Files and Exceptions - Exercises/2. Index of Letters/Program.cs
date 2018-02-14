using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] input = File.ReadAllText("input.txt").ToCharArray();
            List<string> result = new List<string>();
            foreach (var word in input)
            {
                result.Add(word + " -> " + Array.IndexOf(alpha,word));
                
            }
            File.WriteAllLines("output.txt", result);

        }
    }
}
