using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int count = int.Parse(Console.ReadLine())+1;        
        int Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            int check = text[i];
            if (check == Search) 
            {
                hasMatch = true;
                int endIndex = count;
                if (endIndex >= text.Length-i)
                {
                    
                    string substr = text.Substring(i);
                    Console.WriteLine(substr);
                }
                else
                {
                    string substr = text.Substring(i, endIndex);
                    Console.WriteLine(substr);
                }
                
               
                
                i += count-1;
            }
            
        }
        if (!hasMatch)
        {
            Console.WriteLine("no");
        }

    }
}
