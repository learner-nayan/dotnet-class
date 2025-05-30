using System.Security.Cryptography;

namespace ConsoleApp1.SessionThree;

public class Increment
{
    private int value;

    public Increment(int value)
    {
        this.value = value;
    }

    public static Increment operator ++(Increment obj)
    {
        System.Console.WriteLine("Increment");
        return new Increment(obj.value + 10);
    }

    public override string ToString()
    {
        return $"{value}";
    }
}

// overloading binary operator
public class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real , c1.Imaginary + c2.Imaginary);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}!";
    }
}