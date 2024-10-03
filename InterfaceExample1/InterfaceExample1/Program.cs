namespace InterfaceExample1;

class Program
{
    static void Main(string[] args)
    {
        /*TallGuy tallGuy = new TallGuy() { Name = "Jasiek", Height = 176 };
        tallGuy.TalkAboutYourself();
        Console.WriteLine($"Ten wysoki gość ma {tallGuy.FunnyThingIHave}.");
        tallGuy.Honk();*/

        /*IClown fingersTheClown = new ScaryScary("wielkie czerwone nosy", 14);
        fingersTheClown.Honk();
        if (fingersTheClown is IScaryClown scaryClown)
        {
            scaryClown.ScaryLittleChildren();
        }*/

        IClown.CarCapacity = 18;
        Console.WriteLine(IClown.ClownCarDescription());
    }
}