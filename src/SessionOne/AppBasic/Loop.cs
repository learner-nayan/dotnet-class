using System.Reflection.Metadata;

namespace ConsoleApp1.SessionOne.AppBasic;

using System;

public static class Loop
{
    public static void Run()
    {
        int[] arr = [1, 2, 4, 9];
       
        foreach (var num in arr)
        {
            Console.WriteLine(num);
        }
    }
}

