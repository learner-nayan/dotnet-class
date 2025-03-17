namespace ConsoleApp1.SessionOne.AppBasic;

using System;

public static class Character
{
    public static void RunTheCharacter()
    {
        int numOne = 20;
        char copyright = '\u00A9';
        char trademark = '\u00A9';
        string firstName = "Durgesh";
        string lastName = "Thapa";
        
        string fullName = firstName + " " + lastName;
        bool result = firstName == lastName;
        Console.WriteLine(firstName.CompareTo(lastName) == 0);

        if (firstName.CompareTo(lastName) == 0)
        {
            Console.WriteLine("First name is equal to last name");
        }
    }
}