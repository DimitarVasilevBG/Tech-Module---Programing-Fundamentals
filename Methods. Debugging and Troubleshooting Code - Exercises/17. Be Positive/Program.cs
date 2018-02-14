using System;
using System.Collections.Generic;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());
        List<string> result = new List<string>();
        for (int i = 0; i < countSequences; i++)
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            List<double> numbers = new List<double>();

            for (int j = 0; j < input.Length; j++)
            {
                if (!input[j].Equals(string.Empty))
                {
                    double num = double.Parse(input[j]);
                    numbers.Add(num);
                }
            }
        
            bool found = false;
            string str = "";

            for (int j = 0; j < numbers.Count; j++)
            {
                double currentNum = numbers[j];
                if (currentNum >= 0)
                {
                    if (found)
                    {
                        str += " ";
                    }

                    str += currentNum.ToString();

                    found = true;
                }
                else if (j<=numbers.Count-2)
                {

                    currentNum += numbers[j + 1];
                    j += 1;
                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            str += " ";
                        }

                        str += currentNum.ToString();

                        found = true;
                    }
                }
                if (found&&j==numbers.Count-1)
                    result.Add(str);
            }
            
            if (!found)
            {
                
                result.Add("(empty)");
            }

        }
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}