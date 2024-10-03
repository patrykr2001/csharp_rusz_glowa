namespace InterfaceExample1;

public class FunnyFunny : IClown
{
    private string funnyThinkIHave;
    public string FunnyThingIHave => funnyThinkIHave;

    public FunnyFunny(string funnyThinkIHave)
    {
        this.funnyThinkIHave = funnyThinkIHave;
    }

    public void Honk()
    {
        Console.WriteLine($"Cześć dzieciaki! Mam {funnyThinkIHave}.");
    }
}