namespace linq_lazy_example;

class PrintWhenGetting
{
    private int _instanceNumber;

    public int InstanceNumber
    {
        set => _instanceNumber = value;
        get
        {
            Console.WriteLine($"Pobieranie nr {_instanceNumber}");
            return _instanceNumber;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var listOfObjects = new List<PrintWhenGetting>();
        for (int i = 0; i < 5; i++)
        {
            listOfObjects.Add(new PrintWhenGetting() { InstanceNumber = i });
        }
        
        Console.WriteLine("Przygotowanie kwerendy");
        var result =
            from o in listOfObjects
            select o.InstanceNumber;
        
        Console.WriteLine("Uruchamianie pętli foreach");
        foreach (var number in result)
        {
            Console.WriteLine($"Zapis nr {number}");
        }
        
        Console.WriteLine("Pobieranie kwerendy odrazu");
        var immediate = result.ToList();
        Console.WriteLine("Uruchamianie pętli foreach");
        foreach (var number in immediate)
        {
            Console.WriteLine($"Zapis nr {number}");
        }
    }
}