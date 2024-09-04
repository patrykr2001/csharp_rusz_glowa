namespace VirtualOverrideConsole;

public class SafeOwner
{
    private string _valuables = "";

    public void ReceiveContents(string safeContents)
    {
        _valuables = safeContents;
        Console.WriteLine($"Moje {_valuables}! Dziękuje za zwrot!");
    }
}