﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ID = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Employee ID: {0:D8}",ID);
            Console.WriteLine("Salary: {0:F2}",salary);


        }
    }
}
