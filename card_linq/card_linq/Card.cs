namespace card_linq;

public class Card : IComparable<Card>
{
    public CardSuit Suit { get; set; }
    public CardValue Value { get; set; }
    
    public string Name => $"{Value} {Suit}";
    
    public override string ToString() => Name;

    public Card(CardSuit suit, CardValue value)
    {
        Suit = suit;
        Value = value;
    }

    public int CompareTo(Card? other)
    {
        return new CardComparerByValue().Compare(this, other);
    }
}

public class CardComparerByValue : IComparer<Card>
{
    public int Compare(Card? x, Card? y)
    {
        if (x.Value > y.Value) return 1;
        else if (x.Value < y.Value) return -1;
        else return 0;
    }
}