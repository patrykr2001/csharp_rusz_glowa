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

    public void HearMessage(string message, Elephant whoSaidIt)
    {
        Console.WriteLine(Name + " usłyszał(a) wiadomość.");
        Console.WriteLine(whoSaidIt.Name + " powiedział(a): " + message);
    }

    public void SpeakTo(Elephant whoToTalkTo, string message)
    {
        whoToTalkTo.HearMessage(message, this);
    }
}