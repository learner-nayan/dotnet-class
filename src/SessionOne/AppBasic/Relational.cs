namespace ConsoleApp1.SessionOne.AppBasic;

public static class Relational
{
    public static void Run()
    {
        int primary = 10;
        int secondary = 20;

        bool isEqual = primary == secondary;
        bool isNotEqual = primary != secondary;
        bool isGreaterThan = primary > secondary;
        bool isLessThan = primary < secondary;
        bool isGreaterThanOrEqual = primary >= secondary;
        bool isLessThanOrEqual = primary <= secondary;

        if (!isEqual)
        {
            Console.WriteLine("Inside nor");
        }

        if ((!isLessThan || isGreaterThanOrEqual) && !isEqual)
        {
            Console.WriteLine("Inside OR");
        } 
        
        Console.WriteLine(
            $"{primary} == {secondary} ? {isEqual}\n" +
            $"{primary} != {secondary} ? {isNotEqual}\n" +
            $"{primary} > {secondary} ? {isLessThan}\n" +
            $"{primary} <= {secondary} ? {isGreaterThanOrEqual}\n" +
            $"{primary} <= {secondary} ? {isLessThanOrEqual}\n"
        );
    }
}

