namespace InterfaceExample1;

public interface IClown
{
    string FunnyThingIHave { get;  }
    void Honk();
    
    protected static Random random = new Random();

    protected static int carCapacity = 12;

    public static int CarCapacity
    {
        get => carCapacity;
        set
        {
            if (value > 10) carCapacity = value;
            else Console.Error.WriteLine($"Uwaga: pojemność autka, {value} jest za mała!");
        }
    }

    public static string ClownCarDescription()
    {
        return $"Liczba klaunów w autku: {random.Next(carCapacity / 2, carCapacity)}.";
    }
}

interface IScaryClown : IClown
{
    string ScaryThingIHave { get; }
    void ScaryLittleChildren();

    void ScareAdults()
    {
        Console.WriteLine($@"Jestem pradawny złem prześladującym Cię w snach.
Spójrz na mój przerażający naszyjnik z {random.Next(4, 10)} palcami moich ofiar.
A, byłbym zapomniał...");
        ScaryLittleChildren();
    }
}