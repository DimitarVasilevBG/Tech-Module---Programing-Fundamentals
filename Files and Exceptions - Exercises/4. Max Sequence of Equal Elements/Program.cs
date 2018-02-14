using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split(' ').ToArray();
            int count = 0;
            int maxcount = 0;
            string str = "";
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                str = input[i];
                for (int o = i + 1; o < input.Length; o++)
                {
                    if (input[i] == input[o])
                    {
                        count++;
                        str += " " + input[i];
                    }
                    else
                        break;

                }
                if (count > maxcount)
                {
                    maxcount = count;
                    result = str;
                }
                count = 0;
            }
            if (maxcount == 0)
                File.WriteAllText("output.txt", input[0]);
            else
                File.WriteAllText("output.txt", result);
        }
    }
}
