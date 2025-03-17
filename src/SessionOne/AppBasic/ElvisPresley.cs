namespace ConsoleApp1.SessionOne.AppBasic;

using System;

public class Address
{
    public string? Street {get; set; }

    public void ShowInfo()
    {
        Console.WriteLine("This is inside Address");
    }
}

public class User
{
    private const int age = 30;
    public const bool _isMarried = true;
    
    public string? Name { get; set; }
    public Address? Age { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}\nIsMarried: {_isMarried}");
    }
}
