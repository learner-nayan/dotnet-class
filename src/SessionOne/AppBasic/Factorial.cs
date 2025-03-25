namespace ConsoleApp1.SessionOne.AppBasic;

using System.Text;

public static class Factorial{
    public static void Run()
    {
        int factorialNumber = 4;
        int result = GetFactorial(factorialNumber);
        
        Console.WriteLine($"The factial is: {result}");

        BuildString();
    }

    private static int GetFactorial(int number)
    {
        if (number < 1) return 0;
        return number * GetFactorial(number - 1);
    }

    private static void BuildString()
    {
        StringBuilder name = new StringBuilder("Raju");
        Console.WriteLine(name);
        
        StringBuilder address = new StringBuilder("Rautahat");
        StringBuilder street = address;
        // street = "hello";
        
        
        Console.WriteLine(street);
    }
}