namespace  ConsoleApp1.SessionOne.AppBasic;

using System;

public static class BaseType
{
    public static void Run()
    {
        int numOne = 10;
        int numTwo = 20;
        int sum = numOne + numTwo;
        
        DateTime currentTime = DateTime.Now;

        const string firstName = "Salman Khan";
        
        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The name is " + firstName.ToUpper() + "" + numOne);
        Console.WriteLine($"Time is {currentTime}");
        Console.WriteLine("\nTypes");
        Console.WriteLine($"numOne >> {numOne.GetType()}");
    }
}

