using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            char[] charArrayLeft = input[0].ToCharArray();
            char[] charArrayRight = input[1].ToCharArray();
            HashSet<char> SetLeft = new HashSet<char>();
            HashSet<char> SetRight = new HashSet<char>();
            foreach (var item in charArrayLeft)
            {
                SetLeft.Add(item);
            }
            foreach (var item in charArrayRight)
            {
                SetRight.Add(item);
            }
            if(SetLeft.Count == SetRight.Count)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
