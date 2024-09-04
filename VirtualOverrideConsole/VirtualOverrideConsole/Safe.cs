namespace VirtualOverrideConsole;

public class Safe
{
    private string _contents = "cenne klejnoty";
    private string _safeCombination = "12345";

    public string Open(string combination)
    {
        if (combination.Equals(_safeCombination))
        {
            return _contents;
        }
        return "";
    }

    public void PickLock(Locksmith lockpicker)
    {
        lockpicker.Combination = _safeCombination;
    }
}