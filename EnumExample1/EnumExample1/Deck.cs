namespace EnumExample1;

public class Deck
{
    private readonly Card[] _cards = new Card[52];

    public Deck()
    {
        int index = 0;
        for (int suit = 0; suit <= 3; suit++)
        {
            for (int value = 1; value <= 13; value++)
            {
                _cards[index++] = new Card((CardSuit)suit, (CardValue)value);
            }
        }
    }

    public void PrintCards()
    {
        for (int i = 0; i < _cards.Length; i++)
        {
            Console.WriteLine($"{_cards[i].Name}");
        }
    }
}