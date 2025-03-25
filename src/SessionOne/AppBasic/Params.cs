namespace ConsoleApp1.SessionOne.AppBasic;

using System;

public static class Params
{
    public static void Run()
    {
        int mainNumber = 10;

        AddNumber(num: 1);
        
        IncrementByOne(ref mainNumber);
        Console.WriteLine($"Main number is {mainNumber}");
        
        JumbleNumbers(a: 5, b: 6, out int numOne, out int numTwo);

        Console.WriteLine($"Sum of params = {MajorSum(1,1,1,1)}\n");
        
        MajorMultiplication(6,1,2,3,4,5,6);
    }

    public static void AddNumber(int num)
    {
        int result = num + num;
        Console.WriteLine(result);
    }

    public static void IncrementByOne(ref int num)
    {
        num += num;
        Console.WriteLine($"New number is {num}");
    }

    private static bool JumbleNumbers(int a, int b, out int x, out int y)
    {
        x = b;
        y = a;
        return true;
    }

    private static int MajorSum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers) sum += num;
        return sum;
    }

    private static void MajorMultiplication(params int[] numbers)
    {
        int [,] result = new int[numbers.Length, 5];

        // calculating and saving result
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                result[i, j] = numbers[i] * (j + 1);
            }
        }
        
        // formatting and displaying the result
        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.Write($"Multiplication of {numbers[i]} = ");
            for (int j = 0; j < 5; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}