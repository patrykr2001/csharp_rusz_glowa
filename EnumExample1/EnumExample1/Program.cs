namespace EnumExample1;

class Program
{
    static void Main(string[] args)
    {
        Random random = new();
        var suitNumber = random.Next(0, 4);
        var valueNumber = random.Next(1, 14);
        Card myCard = new Card((CardSuit)suitNumber, (CardValue)valueNumber);
        Console.WriteLine(myCard.Name);
    }
}