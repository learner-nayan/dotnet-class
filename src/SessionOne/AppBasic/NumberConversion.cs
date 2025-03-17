namespace ConsoleApp1.SessionOne.AppBasic;

using System;

public static class NumberConversion
{
    public static void Run()
    {
        int numOne = 10;
        short numFour = 0;
        decimal numTwo = 20.11m;

        long numThree = numOne;
        
        float numFive = (float) numTwo;
        
        int numSix = (int) numThree;
        
        Type intType = typeof(int);

        if (numTwo >= short.MinValue && numTwo <= short.MaxValue)
        {
            numFour = (short) numTwo;
            Console.WriteLine("numTwo type casting into short successful");
        }
        
        Console.WriteLine("\nResult: ");
        Console.WriteLine(
            $"numOne > {numOne.GetType()} > {numOne}\n" + 
            $"numTwo > {numTwo.GetType()} > {numTwo}\n" +
            $"numThree > {numThree.GetType()} > {numThree}\n" +
            $"numFive > {numFive.GetType()} > {numFive}\n" +
            $"numFour {numFour.GetType()} > {numFour}\n" +
            $"numSix > {numSix.GetType()} > {numSix}\n" +
            $"Int type information >> {intType}"
        ); 
    }
}