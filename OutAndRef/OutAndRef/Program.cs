namespace OutAndRef;

class Guy
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

class Program
{
    static void Main()
    {
        Guy guy = new Guy { Name = "Tom", Age = 23 };
        Console.WriteLine(guy);
        ChangeGuy(guy);
        Console.WriteLine(guy);
        ChangeGuyOut(out guy);
        Console.WriteLine(guy);
        ChangeGuyRef(ref guy);
        Console.WriteLine(guy);
    }

    static void ChangeGuy(Guy guy)
    {
        guy = new Guy { Name = "Alice", Age = 25 };
    }

    static void ChangeGuyOut(out Guy guy)
    {
        guy = new Guy { Name = "Ariel", Age = 30 };
    }

    static void ChangeGuyRef(ref Guy guy)
    {
        guy = new Guy { Name = "Alice", Age = 25 };
    }
}