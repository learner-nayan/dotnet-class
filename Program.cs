using System;
namespace ConsoleApp1;

using SessionOne.AppBasic;

internal class Program
{
    private static void Main(String[] args)
    {
        Console.WriteLine("Nayan dada hajur don ho");
        String data = String.Join(",", args);
        Console.WriteLine(data);
        
        //BaseType.Run();
        //Character.RunTheCharacter();
        //RandomBoolean.Run();
        //Arithmetic.Run();
        //Relational.Run();
        // Loop.Run();
        // NumberConversion.Run();
        // CopyValue.Run();
        // User.ShowInfo();
        // ElvisPresley.Run();
        // Miscellaneous.Run();
        // NormalArray.Run();
        // RectangularArray.Run();
        JaggedArray.Run();

    }
}