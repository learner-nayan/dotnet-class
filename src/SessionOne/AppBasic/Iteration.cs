namespace ConsoleApp1.SessionOne.AppBasic;
using System;

public static class Iteration
{
    public static void Run()
    {
        int number;
        int counter = 1;
        string userInput;
        bool isValueInput;

        while (counter <= 5)
        {
            Console.WriteLine($"Counter -{counter}");
            counter++;
        }
        
        Console.WriteLine("Enter yout name:");
        while ((userInput = Console.ReadLine() ?? "") != "exit")
        {
            Console.WriteLine($"\nYou entered: {userInput}");
        }

        do
        {
            Console.WriteLine("\nPlease enter a valid integer");
            isValueInput = int.TryParse(Console.ReadLine(), out number);
            if (!isValueInput)
            {
                Console.WriteLine("Please try again");
            }
        } while (!isValueInput);
        
        Console.WriteLine($"\nYou entered: {number}");

        for (int i = 1; i < 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"*\t");
            }
            Console.WriteLine();
        }
    }
}
