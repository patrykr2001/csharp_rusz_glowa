namespace PickACardUI;

public class CardPicker
{
    static Random _random = new Random();

    public static string[] PickSomeCards(int numberOfCards)
    {
        var pickedCards = new string[numberOfCards];
        for (var i = 0; i < numberOfCards; i++)
        {
            pickedCards[i] = RandomValue() + " " + RandomSuit();
        }

        return pickedCards;
    }

    private static string RandomSuit()
    {
        var value = _random.Next(1, 5);
        return value switch
        {
            1 => "pik",
            2 => "kier",
            3 => "trefl",
            _ => "karo"
        };
    }

    private static string RandomValue()
    {
        var value = _random.Next(1, 14);
        return value switch
        {
            1 => "As",
            11 => "Walet",
            12 => "Dama",
            13 => "Król",
            _ => value.ToString()
        };
    }
}