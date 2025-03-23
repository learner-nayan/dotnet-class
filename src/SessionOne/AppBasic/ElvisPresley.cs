namespace ConsoleApp1.SessionOne.AppBasic;

using System;

public class Address {
    public string? Street {get; set; }

    public void ShowInfo() {
        System.Console.WriteLine($" This is inside Address");
    }
}

public class User{

    private const int _age = 30;

    private const bool _isMarried = true;

    public string? Name { get; set;}

    public Address? Address {get; set;}

    public void showInfo() {
        System.Console.WriteLine($"Name: {Name}\nAge: {_age}\nIsMarried: {_isMarried}");
    }
}

public static class ElvisPresley{
    public static void Run()
    {
        User user = new User();
        user.Name = "Desi boy Sallu Mia";
        // user.Address.Street = "London";
        
        Address address = new Address();
        address.Street = "Antarctica";
        
        string userName = user.Name;
        string saperatesStreet = address.Street;
        string userStreet = user?.Address?.Street ?? "Default Street";
        
        Console.WriteLine($"User name is {userName}🥰");
        Console.WriteLine($"User name is {saperatesStreet}");

        if (userStreet is not null)
        {
            Console.WriteLine($"User street is {userStreet}");
        }
        else
        {
             Console.WriteLine("User street is null");
        }
    }

}
