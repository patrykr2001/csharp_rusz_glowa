namespace ElephantProgram;

public class Elephant
{
    public string Name;
    public int EarSize;

    public void WhoAmI()
    {
        Console.WriteLine("Na imię mam " + Name + ".");
        Console.WriteLine("Długość moich uszu to " + EarSize + " cm .");
    }
}