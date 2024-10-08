namespace EnumExample1;

public class Card
{
    public CardSuit Suit { get; set; }
    public CardValue Value { get; set; }
    
    public string Name => $"{Value} {Suit}";

    public Card(CardSuit suit, CardValue value)
    {
        Suit = suit;
        Value = value;
    }
}