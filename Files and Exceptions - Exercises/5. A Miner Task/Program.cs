using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt").ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            int value = 0;
            int OddorEven = 1;
            for (int i = 0; true ; i++)
            {
                if (input[i] == "stop")
                    break;
                if(OddorEven%2!=0)
                {
                    if (dict.ContainsKey(input[i]))
                    {
                    }
                    else
                        dict[input[i]] = 0;
                }
                else
                {
                    value = int.Parse(input[i]);
                    dict[input[i-1]] += value;

                }
                OddorEven++;
            }
            List<string> result = new List<string>();
            foreach (var miner in dict)
            {
                result.Add(miner.Key +" -> "+ miner.Value);
            }
            File.WriteAllLines("output.txt", result);
        }
    }
}
