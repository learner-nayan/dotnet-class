namespace ConsoleApp1.SessionOne.AppBasic;

public static class Miscellaneous
{
    public static unsafe void Run()
    {
        int year=2025;
        int intsize=sizeof(int);
        int charSize=sizeof(char);
        int floatSize=sizeof(float);
        int doubleSize=sizeof(double);
        
        int* yearPointer = &year; //creating a pointer
         
        System.Console.WriteLine(
            $"sizeof(int)={intsize}\n" +
            $"sizeof(char)={charSize}\n" +
            $"sizeof(float)={floatSize}\n" +
            $"sizeof(double)={doubleSize}\n" 
        );
        System.Console.WriteLine($"type of int={typeof(int)}");
        System.Console.WriteLine($"type of char={typeof(char)}");
        System.Console.WriteLine($"'year' addres in Memory =" +(int)yearPointer);

        User john = new User();
        if (john is User)
        {
            john.Name = "John Smith";
            john.showInfo();
        }

        object? planet = null;
        string mercury = planet as string ?? "Earth";
        
        Console.WriteLine($"\nmercury={mercury} \t type of planet={mercury.GetType()}");

        int maxResult = CheckMax(a:20, b:40, c:25);
        
        Console.WriteLine($"\nmaxResult={maxResult}");
    }

    private static int CheckMax(int a, int b, int c)
    {
        return a > b && a > c ? a : b > c && b > a ? b : c;
    }
}