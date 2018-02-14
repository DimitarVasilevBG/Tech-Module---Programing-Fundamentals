using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] str2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int min = Math.Min(str1.Length, str2.Length);
            List<string> result = new List<string>();
            for (int i = 0; i < min; i++)
            {
                if (string.Join("", str1).Equals(string.Join("", str2)))
                {
                    Console.WriteLine(string.Join("", str1));
                    Console.WriteLine(string.Join("", str2));
                    break;
                }
                else if (str1[i] == str2[i])
                {
                    result.Add(str1[i]);
                    if (i == min - 1)
                    {
                        Console.WriteLine(string.Join("", result));
                        if (str1.Length < str2.Length)
                            Console.WriteLine(string.Join("", str2));
                        else
                            Console.WriteLine(string.Join("", str1));
                    }
                }
                else if (str1.Length == str2.Length)
                {
                    if (String.Compare(string.Join("", str1), string.Join("", str2)) < 0)
                    {
                        Console.WriteLine(string.Join("", str1));
                        Console.WriteLine(string.Join("", str2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", str2));
                        Console.WriteLine(string.Join("", str1));
                        break;
                    }
                }
                else
                {
                   
                     if (String.Compare(string.Join("", str1), string.Join("", str2)) < 0)
                    {
                        Console.WriteLine(string.Join("", str1));
                        Console.WriteLine(string.Join("", str2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", str2));
                        Console.WriteLine(string.Join("", str1));
                        break;
                    }

                }
               
            }
        }
    }
}
