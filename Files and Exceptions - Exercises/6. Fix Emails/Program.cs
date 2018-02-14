using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt").ToArray();
            Dictionary<string, string> person = new Dictionary<string, string>();

            for (int i = 0; true; i++)
            {
                if (input[i] == "stop")
                    break;
                if(i%2==0)
                {
                    if (person.ContainsKey(input[i]))
                    { }
                    else
                        person[input[i]] = "";
                }
                else
                {
                    if(input[i].ToLower().EndsWith("us")|| input[i].ToLower().EndsWith("uk"))
                    {
                        person.Remove(input[i - 1]);
                    }
                    else
                    {
                        person[input[i - 1]] = input[i];
                    }
                }
            }
            List<string> result = new List<string>();
            foreach (var element in person)
            {
                result.Add(element.Key +" -> " + element.Value);
            }

            File.WriteAllLines("output.txt", result);



        }
    }
}
