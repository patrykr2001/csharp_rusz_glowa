namespace InterfaceExample1;

public class ScaryScary : FunnyFunny, IScaryClown
{
    private int scaryThingCount;

    public ScaryScary(string funnyThinkIHave, int scaryThingCount) : base(funnyThinkIHave)
    {
        this.scaryThingCount = scaryThingCount;
    }

    public string FunnyThingIHave => $"pająki -- {scaryThingCount}";

    public string ScaryThingIHave { get; }
    
    public void ScaryLittleChildren()
    {
        Console.WriteLine($"Ha! Mam was! Zobaczcie moje {scaryThingCount}!");
    }
}