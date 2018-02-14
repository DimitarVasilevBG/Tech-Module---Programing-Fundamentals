using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static List<string> invalid = new List<string>();
        static void Main(string[] args)
        {
             string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            while (true)
            {
                try
                {
                    string command = Console.ReadLine();
                    if (command == "end") break;

                    string[] input = command.Split(' ').ToArray();
                    if (input[0] == "sort")
                    {
                        numbers = ArraySort(numbers,input[2], input[4]);
                    }
                    else if (input[0] == "reverse")
                    {
                        numbers = ArrayReverse(numbers, input[2], input[4]);
                    }
                    else if (input[0] == "rollLeft")
                    {
                        numbers = ArrayRollLeft(numbers, input[1]);
                    }
                    else if (input[0] == "rollRight")
                    {
                        numbers = ArrayRollRight(numbers, input[1]);
                    }
                }
                catch
                {
                    invalid.Add("Invalid input parameters.");
                }
            }
            foreach (var item in invalid)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("["+string.Join(", ",numbers)+"]");
        }

        private static string[] ArrayRollRight(string[] numbers, string v)
        {
            int roll = int.Parse(v);
            if (roll < 0) { invalid.Add("Invalid input parameters."); return numbers; }
            for (int i = 0; i < roll; i++)
            {
                string last = numbers.Last();
                for (int o = numbers.Length-1; o > 0; o--)
                {
                     numbers[o] = numbers[o - 1];
                }
                numbers[0] = last;
            }
            return numbers;
        }

        private static string[] ArrayRollLeft(string[] numbers, string v)
        {
            int roll = int.Parse(v);
            if (roll < 0) { invalid.Add("Invalid input parameters."); return numbers; }
            for (int i = 0; i < roll; i++)
            {
                string first = numbers.First();
                for (int o = 0; o < numbers.Length-1; o++)
                {
                    numbers[o] = numbers[o+1];
                }
                numbers[numbers.Length - 1] = first;
            }
            
            return numbers;
        }

        private static string[] ArraySort(string[] numbers, string v1, string v2)
        {
            int start = int.Parse(v1);
            int end = int.Parse(v2);
            if (start < 0 || end < 0) { invalid.Add("Invalid input parameters.");return numbers;}
            string[] portion = numbers.Skip(start).Take(end).ToArray();
            int index = 0;
            portion = portion.OrderBy(x=>x).ToArray();
            for (int i = start; i < start+end; i++)
            {
                numbers[i] = portion[index];
                index++;
            }
            return numbers;
        }
        private static string[] ArrayReverse(string[] numbers, string v1, string v2)
        {
            int start = int.Parse(v1);
            int end = int.Parse(v2);
            if (start < 0 || end < 0) { invalid.Add("Invalid input parameters."); return numbers; }
            string[] portion = numbers.Skip(start).Take(end).ToArray();
            int index = 0;
            portion = portion.Reverse().ToArray();
            for (int i = start; i < start + end; i++)
            {
                numbers[i] = portion[index];
                index++;
            }
            return numbers;
        }
    }
}
