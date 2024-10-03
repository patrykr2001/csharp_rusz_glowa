namespace InterfaceExample1;

class Program
{
    static void Main(string[] args)
    {
        TallGuy tallGuy = new TallGuy() { Name = "Jasiek", Height = 176 };
        tallGuy.TalkAboutYourself();
        Console.WriteLine($"Ten wysoki gość ma {tallGuy.FunnyThingIHave}.");
        tallGuy.Honk();
    }
}