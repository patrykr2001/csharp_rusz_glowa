namespace HiLoGameConsole;

public static class HiLoGame
{
    public const int MAXIMUM = 10;
    private static Random random = new Random();
    private static int currentNumber = random.Next(1, MAXIMUM + 1);
    private static int pot = 10;

    public static int GetPot()
    {
        return pot;
    }

    public static void Guess(bool higher)
    {
        var next = random.Next(1, MAXIMUM + 1);
        if ((higher && next < MAXIMUM) || (!higher && next > MAXIMUM))
        {
            Console.WriteLine("Zgadłeś!");
            pot++;
        }
        else
        {
            Console.WriteLine("Niestety, błędna odpowiedź.");
            pot--;
        }
        
        currentNumber = next;
        Console.WriteLine($"Aktualna wartość to: {currentNumber}.");
    }

    public static void Hint()
    {
        var half = MAXIMUM / 2;
        if (currentNumber >= half)
        {
            Console.WriteLine($"Liczba znajduje się w górnej {half}.");
        }
        else
        {
            Console.WriteLine($"Liczba znajduje się w dolnej {half}.");
        }

        pot--;
    }
}