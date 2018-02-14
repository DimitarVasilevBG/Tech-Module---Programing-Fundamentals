using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string line = command.Trim();
            int[] args = new int[2];

            if (command.Contains("add") ||
                command.Contains("subtract") ||
                command.Contains("multiply"))
            {
                string[] stringParams = line.Split(ArgumentsDelimiter);
                command = stringParams[0].ToString();
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);

                array= PerformAction(array, command, args);
            }
            else if (command.Contains("rshift")||command.Contains("lshift"))
                array = PerformAction(array, command, args);

            PrintArray(array);
            //Console.WriteLine('\n');

            command = Console.ReadLine();
        }
    }

    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos-1] *= value;
                break;
            case "add":
                array[pos-1] += value;
                break;
            case "subtract":
                array[pos-1] -= value;
                break;
            case "lshift":
                array = ArrayShiftLeft(array);
                break;
            case "rshift":
                array = ArrayShiftRight(array);
                break;
        }
        return array;
    }

    static long[] ArrayShiftRight(long[] array)
    {
        long copy = array[array.Length-1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = copy;
        return array;
    }

    static long[]  ArrayShiftLeft(long[] array)
    {
        long copy = array[0];
        for (int i = 0; i <= array.Length - 2; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = copy;
        return array;
    }

    private static void PrintArray(long[] array)
    {
        Console.WriteLine(string.Join(" ",array));
    }
}
