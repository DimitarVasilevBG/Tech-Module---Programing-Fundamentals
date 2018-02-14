using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})([0-9]+.[0-9]+)([a-zA-z]+)[|]";
            Dictionary<string,SortedDictionary<double, string>> dict = new Dictionary<string, SortedDictionary<double, string>>();
            while (true)
            {

                string input = Console.ReadLine();
                if (input == "end")
                    break;
                if (Regex.IsMatch(input, pattern))
                {
                    Match regex = Regex.Match(input, pattern);
                    string cityName = regex.Groups[1].ToString();
                    double temperature = double.Parse(regex.Groups[2].ToString());
                    string weather = regex.Groups[3].ToString();
                    if (!dict.ContainsKey(cityName))
                    {
                        dict[cityName] = new SortedDictionary<double, string>();
                        dict[cityName].Add(temperature, weather);
                    }
                    else
                    {

                        dict[cityName] = new SortedDictionary<double, string>();
                        dict[cityName].Add(temperature, weather);
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x=>x.Value))
            {

                Console.WriteLine("{0}{1}");

            }
        }

    }
}

