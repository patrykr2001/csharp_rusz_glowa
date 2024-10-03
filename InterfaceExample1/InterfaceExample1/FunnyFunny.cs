namespace InterfaceExample1;

public class FunnyFunny : IClown
{
    public string FunnyThingIHave { get; }

    protected FunnyFunny(string funnyThinkIHave)
    {
        this.FunnyThingIHave = funnyThinkIHave;
    }

    public void Honk()
    {
        Console.WriteLine($"Cześć dzieciaki! Mam {FunnyThingIHave}.");
    }
}