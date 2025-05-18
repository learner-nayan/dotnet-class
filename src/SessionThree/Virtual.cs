namespace ConsoleApp1.SessionThree;

public class User
{
    // virtual method with implementation
    public virtual void Greet()
    {
        System.Console.WriteLine("Hello");
    }

    public class AdminUser : User
    {
        public override void Greet()
        {
            Console.WriteLine("Greetings, administrator");
        }
    }
    
    public class GuestUser : User
    {
        public override void Greet()
        {
            Console.WriteLine("Welcome, guest");
        }
    }
}