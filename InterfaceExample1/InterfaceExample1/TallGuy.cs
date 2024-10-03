namespace InterfaceExample1;

public class TallGuy : IClown
{
    public string Name;
    public int Height;

    public void TalkAboutYourself()
    {
        Console.WriteLine($"Nazywam się {Name}. Mam {Height} cm wzrostu");
    }

    public string FunnyThingIHave => "wielkie buty";

    public void Honk()
    {
        Console.WriteLine("Bip, bip!");
    }
}