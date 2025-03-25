public static class Selection
{
    public static void Run()
    {
        uint number = uint.Parse(Console.ReadLine());
        bool isActive = true;
        bool isLoggedIn = false;
        int i = 35, j = 20, k = 30;
        
        // Nested if
        if (isLoggedIn && isActive)
        {
            if (i < j && i < k) Console.WriteLine("i is greatest");
            if (j > k && j < i) Console.WriteLine("j is greatest");
            else Console.WriteLine("k is greatest");
        }
        else Console.WriteLine("Invalid user");
        
        // If else ladder
        if (i == j)
        {
            Console.WriteLine("i is equal to j");
        } else if (i > k)
        {
            Console.WriteLine("i is greater than k");
        } else if (j > i)
        {
            Console.WriteLine("j is greater than i");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

        switch (number)
        {
            case 1: 
                Console.WriteLine("The number is 1");
                break;
            case 2:
                Console.WriteLine("The number is 2");
                break;
            case 3:
                Console.WriteLine("The number is 3");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}