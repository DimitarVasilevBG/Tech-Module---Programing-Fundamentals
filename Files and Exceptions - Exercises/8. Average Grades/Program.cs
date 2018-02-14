using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            int StudentCount = int.Parse(File.ReadLines("input.txt").First());
            string[] read = File.ReadAllLines("input.txt").Skip(1).ToArray();
            List<Person> list = new List<Person>();
            List<string> result = new List<string>();
            for (int i = 0; i < StudentCount; i++)
            {
                //string[] input = Console.ReadLine().Trim().Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] input = read[i].Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries).ToArray();
                double[] marks = input[1].Split(' ').Select(double.Parse).ToArray();
                Person person = new Person();
                person.name = input[0];
                person.Average = marks.Average();
                if (person.Average >= 5)
                    list.Add(person);
            }
            list.OrderBy(x => x.name);
            foreach (var item in list.OrderBy(x => x.name).ThenByDescending(x => x.Average))
            {

                File.AppendAllText("output.txt",($"{item.name} -> {item.Average:F2}")+Environment.NewLine);
            }

        }

        private static void AddStudentsToList(Person person)
        {
            throw new NotImplementedException();
        }
    }
    public class Person
    {
        public string name { get; set; }
        public double Average { get; set; }

    }
}
