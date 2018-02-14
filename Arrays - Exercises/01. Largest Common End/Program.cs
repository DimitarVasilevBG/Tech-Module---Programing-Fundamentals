using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] str2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int count = 0;
            int str1L = str1.Length - 1;
            int str2L = str2.Length - 1;
            int i = 0;
            if(str1[0]==str2[0])
            {
                while (i<= str1L&&i<= str2L&&str1[i] == str2[i])
                {
                    count++;
                    i++;
                
                }
            }
            else if (str1[str1L] == str2[str2L])
            {
                while (str1L >= 0 && str2L >= 0&&str1[str1L] == str2[str2L])
                {
                    count++;
                    str2L -= 1;
                    str1L -= 1;
                }
            }
            Console.WriteLine(count);
        }
    }
}
