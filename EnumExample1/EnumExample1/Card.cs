namespace EnumExample1;

public class Card
{
    public CardSuit Suit { get; set; }
    public CardValue Value { get; set; }

    public Card(CardSuit suit, CardValue value)
    {
        Suit = suit;
        Value = value;
    }
}