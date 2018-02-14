using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();
            int leftresult = 0;
            int rightresult = 0;
            bool condition = false;
            for (int i = 0; i < input.Length; i++)
            {
                for (int l = 0; l < i; l++)
                {
                    leftresult += input[l];
                }
                for (int r = input.Length-1; r > i; r--)
                {
                    rightresult += input[r];
                }
                if (leftresult == rightresult)
                {
                    File.WriteAllText("output.txt", i.ToString());
                    condition = true;
                    break;
                }

                leftresult = 0;
                rightresult = 0;
            }
            if (condition != true)
                File.WriteAllText("output.txt", "no");




        }
    }
}
