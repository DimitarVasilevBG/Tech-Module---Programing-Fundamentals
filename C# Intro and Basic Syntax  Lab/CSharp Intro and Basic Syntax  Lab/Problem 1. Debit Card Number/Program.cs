using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID = int.Parse(Console.ReadLine());
            int ID2 = int.Parse(Console.ReadLine());
            int ID3 = int.Parse(Console.ReadLine());
            int ID4 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", ID,ID2,ID3,ID4);

        }
    }
}
