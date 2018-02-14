using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Phrases = File.ReadAllLines("Phrases.txt").ToArray();
            string[] Events = File.ReadAllLines("Events.txt").ToArray();
            string[] Authors = File.ReadAllLines("Authors.txt").ToArray();
            string[] Cities = File.ReadAllLines("Cities.txt").ToArray();
            int repeat = int.Parse(File.ReadAllText("Repeat.txt"));
            Random rnd = new Random();
            List<string> result = new List<string>();
            for (int i = 0; i < repeat; i++)
            {
                string phrase = Phrases[rnd.Next(0, Phrases.Length)];
                string eve = Events[rnd.Next(0, Events.Length)];
                string author = Authors[rnd.Next(0, Authors.Length)];
                string city = Cities[rnd.Next(0, Cities.Length)];
                result.Add($"{phrase} {eve} {author} – {city}. ");

            }
            File.WriteAllLines("output.txt",result);


        }
    }
}
