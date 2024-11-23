using System.Text.Json;

class Guy
{
    public string Name { get; set; }
    public HairStyle Hair { get; set; }
    public Outfit Clothes { get; set; }
    public override string ToString() => $"{Name} has {Hair} hair and wears {Clothes}";
}

class Outfit
{
    public string Top { get; set; }
    public string Bottom { get; set; }
    public override string ToString() => $"{Top} and {Bottom}";
}

enum HairColor
{
    kasztanowe, czarne, blond, niebieskie, brązowe, szare, platynowe, fioletowe, czerwone, białe
}

class HairStyle
{
    public HairColor Color { get; set; }
    public float Length { get; set; }
    public override string ToString() => $"{Color} hair, {Length:0.0} cm long";
}

class Program
{
    static void Main(string[] args)
    {
        var guys = new List<Guy>()
        {
            new Guy()
            {
                Name = "Borys", Clothes = new Outfit() { Top = "t-shirt", Bottom = "dżinsy" },
                Hair = new HairStyle() { Color = HairColor.czerwone, Length = 8.9f }
            },
            new Guy()
            {
                Name = "Jonasz", Clothes = new Outfit() { Top = "polo", Bottom = "spodnie" },
                Hair = new HairStyle() { Color = HairColor.szare, Length = 6.8f }
            }
        };
        
        var jsonString = JsonSerializer.Serialize(guys);
        Console.WriteLine(jsonString);

        var copyOfGuys = JsonSerializer.Deserialize<List<Guy>>(jsonString);
        foreach (var guy in copyOfGuys)
        {
            Console.WriteLine($"Wykonałem deserializację tego faceta: {guy}");
        }
    }
}