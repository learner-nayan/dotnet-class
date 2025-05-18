namespace ConsoleApp1.SessionThree;

public class Animal
{
    private uint? _age;
    private readonly string? _name;
    private readonly string? _species;

    public string? Name { get; set; }
    public string? Species { get; set; }

    public uint? Age
    {
        get => _age;
        set
        {
            if (value < 18) throw new ArgumentException("Invalid age");
            _age = value;
        }
    }
    
    static Animal()
    {
        Console.WriteLine("This is inside animal static constructor");
    }
    //default constructor
    public Animal(string name, uint age, string species)
    {
        Console.WriteLine("This is inside animal default constructor");
        _age = age;
        _name = name;
        _species = species ?? "N/A";
    }
    public Animal()
    {
        Console.WriteLine("This is animal construdtor withour paramterers");
    }


    public void MakeSound()
    {
        Console.WriteLine($"{_name} is making a sound.");
    }

    public void MakeSound(String animalName)
    {
        Console.WriteLine($"{animalName} is making a sound.");
    }

    public void AnimalDetails()
    {
        Console.WriteLine("Animal Details");
        Console.WriteLine($"Name >> {_name}\nSpecies >> {_species}\nAge >> {_age}");
    }
    
    // Destructure
    ~Animal()
    {
        Console.WriteLine($"{_name} is making a sound.");
    }
    
}

// Kct@2023