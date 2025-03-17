namespace ConsoleApp1.SessionOne.AppBasic;

using System;

public static class Arithmetic
{
    public static void Run()
    {
        int numOne = 4;
        int numTwo = 20;
        int numThree = 12;
        int numFour = 0;
        
        
        int sum = numOne + numTwo;
        int product = numOne * numTwo;
        int remainder = numOne % numTwo;
        int quotient = numOne / numTwo;
        int difference = numOne - numTwo;
        numOne++;
        numTwo--;
        
        Console.WriteLine(
            $"{numOne} + {numTwo} = {sum}\n" +
            $"{numOne} + {numTwo} = {product}\n" +
            $"{numOne} * {numTwo} = {remainder}\n" +
            $"{numOne} / {numTwo} = {quotient}\n" +
            $"{numOne} % {numTwo} = {difference}\n" +
            $"After increment numOne = {numOne}\n" +
            $"After increment numTwo = {numTwo}\n"
        );

        numThree += 10;
        numFour += numThree;
        
        Console.WriteLine("After re-assignment: ");
        Console.WriteLine(
            $"numThree = {numThree}\n" +
            $"numFour = {numFour}\n"
        );
    }
}

