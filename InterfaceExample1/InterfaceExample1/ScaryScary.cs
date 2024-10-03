namespace InterfaceExample1;

public class ScaryScary(string funnyThinkIHave, int scaryThingCount) : FunnyFunny(funnyThinkIHave), IScaryClown
{
    public string ScaryThingIHave => $"pająki -- {scaryThingCount}";
    
    public void ScaryLittleChildren()
    {
        Console.WriteLine($"Ha! Mam was! Zobaczcie moje {ScaryThingIHave}!");
    }
}