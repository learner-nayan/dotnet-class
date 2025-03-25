using System;
namespace ConsoleApp1.SessionOne.AppBasic;

public static class ArraySum
{
    public static void Run()
    {
        int totalNumber, sum = 0;
        int[] numbersToAdd = new int[5];

        Console.Write("Enter the number of elements (5 max): ");
        string totalNumberInput = Console.ReadLine() ?? string.Empty; // Taking input from user

        // Handle more than max number case
        if (!int.TryParse(totalNumberInput, out totalNumber))
        {
            Console.WriteLine("\n❌ Invalid input. Please enter a valid number.");
            return;
        }

        // Handle more than 5
        if (totalNumber > 5)
        {
            Console.WriteLine("\n❌ Invalid input. Please enter a number less than 5.");
            return;
        }

        Console.WriteLine("\nEnter numerical elements:");
        for (int i = 0; i < totalNumber; i++)
        {
            bool isConversionSuccessful = int.TryParse(Console.ReadLine(), out int convertedNumber);

            if (isConversionSuccessful)
            {
                numbersToAdd[i] = convertedNumber;
            }
            else
            {
                numbersToAdd[i] = 0;
            }
        }
        
        // calculating sum with all the array elements
        for (int i = 0; i < numbersToAdd.Length; i++)
        {
            sum += numbersToAdd[i];
        }
        
        Console.WriteLine($"\nThe sum of the elements is {sum}");
    }
}
