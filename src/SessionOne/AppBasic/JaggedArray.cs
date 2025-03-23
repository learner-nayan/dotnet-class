namespace ConsoleApp1.SessionOne.AppBasic;

using System;

public static class JaggedArray
{
    public static void Run()
    {
        int[][] numbers = new int[3][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5},
            new int[] {7}
        };

        char[][] letters = new char[][]
        {
            new char[] {'a', 'e', 'i', 'o', 'u'},
            new char[] {'b', 'c'}
        };

        Console.WriteLine("Elements in numbers list:");
        foreach (int[] rows in numbers)
        {
            foreach (int item in rows)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\nSum of rows:");
        foreach (int[] rows in numbers)
        {
            int sum = 0;
            foreach (int item in rows)
            {
                sum += item;
            }
            Console.WriteLine("Sum of row: " + sum);
        }
    }
}
