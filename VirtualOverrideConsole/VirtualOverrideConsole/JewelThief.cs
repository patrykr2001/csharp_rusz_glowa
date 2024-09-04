namespace VirtualOverrideConsole;

public class JewelThief : Locksmith
{
    private string _stolenJewels;

    protected override void ReturnContents(string safeContents, SafeOwner safeOwner)
    {
        _stolenJewels = safeContents;
        Console.WriteLine($"Kradnę kosztowności! Ukradłem: {_stolenJewels}.");
    }
}