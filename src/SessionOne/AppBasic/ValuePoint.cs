// public class ValuePoint
// {
//     public int X { get; set; }
//     public int Y { get; set; }
// }

public struct ValuePoint
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class CopyValue
{
    public static void Run()
    {
        ValuePoint pointOne = new ValuePoint();
        pointOne.X = 10;

        ValuePoint pointTwo = pointOne;
        
        Console.WriteLine("Before changing value of x in pointOne");
        Console.WriteLine($"Point one X >> {pointOne.X}");
        Console.WriteLine($"Point one X >> {pointTwo.X}");
        
        pointTwo.X = 20;
        
        Console.WriteLine("\nAfter changing value of x in pointTwo");
        Console.WriteLine($"Point two X >> {pointOne.X}");
        Console.WriteLine($"Point two X >> {pointTwo.X}");
    }
}