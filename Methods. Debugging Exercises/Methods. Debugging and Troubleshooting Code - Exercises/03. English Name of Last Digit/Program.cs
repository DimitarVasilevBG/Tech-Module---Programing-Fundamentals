using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {
        static void GetLastNumIntoWords(string s)
        {
            string name = "";
            switch (s)
            {
                case "0":
                    name = "zero";
                        break;
                case "1":
                    name = "One";
                    break;
                case "2":
                    name = "Two";
                    break;
                case "3":
                    name = "Three";
                    break;
                case "4":
                    name = "Four";
                    break;
                case "5":
                    name = "Five";
                    break;
                case "6":
                    name = "Six";
                    break;
                case "7":
                    name = "Seven";
                    break;
                case "8":
                    name = "Eight";
                    break;
                case "9":
                    name = "Nine";
                    break;
            }
            Console.WriteLine(name.ToLower());

        }
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            str = str.Last().ToString();
            GetLastNumIntoWords(str);
        }
    }
}
