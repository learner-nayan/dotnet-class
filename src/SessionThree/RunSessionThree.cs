namespace ConsoleApp1.SessionThree;

public class RunSessionThree
{
    public static void RunAnimal()
    {
        Animal dog = new Animal("Golden", 0, "Nice");
        dog.Age = 10;
        
        dog.MakeSound();
        dog.MakeSound("K xa babu");
        dog.AnimalDetails();
    }

    public static void RunShape()
    {
        Circle ball = new();
        ball.Radius = 10.0;
        ball.Name = "Football";
        
        ShapeManager.PrintShapeInfo(ball);
    }

    public static void RunOperatorOverloading()
    {
        ComplexNumber c1 = new(2, 3);
        ComplexNumber c2 = new(4, 5);
        
        ComplexNumber result = c1 + c2;
        Console.WriteLine(result.ToString());
        
        Increment inc = new(5);
        Increment resulltOne = ++inc;
        Console.WriteLine($"This in incremented value {resulltOne.ToString()}");
    }

    public static void RunAppPolyClass()
    {
        // RunAppPoly.RunDictionary();
        // RunAppPoly.RunQueue();
        // RunAppPoly.RunStack();
        RunAppPoly.RunArrayList();
    }
}