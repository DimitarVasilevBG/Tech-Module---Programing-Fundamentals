using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int seq1start = 0;
            int copy = 0;
            string seq = "";
            string result = "";
            string[] str = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = 0; i < str.Length-1; i++)
            {
                seq = str[i].ToString() + " ";
                for (int o = i+1; o < str.Length; o++)
                {
                    if (str[i] == str[o])
                    {
                        seq1start++;
                        seq += str[i].ToString() + " ";
                        if (seq1start > copy)
                            result = seq;
                    }
                    else
                    {
                        break;
                    }
                }
                copy = Math.Max(seq1start, copy);
                seq1start = 0;
                seq = "";


            }
            Console.WriteLine(result);
        }
    }
}
