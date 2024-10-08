using System.Collections;

namespace card_linq;

public class Deck : IEnumerable<Card>
{
    private static readonly Random Random = new Random();
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
        foreach (var t in _cards)
        {
            Console.WriteLine($"{t.Name}");
        }
    }

    public Deck Shuffle()
    {
        var n = _cards.Length;
        for (var i = n - 1; i > 0; i--)
        {
            var j = Random.Next(i + 1);
            (_cards[i], _cards[j]) = (_cards[j], _cards[i]);
        }
        return this;
    }

    public IEnumerator<Card> GetEnumerator()
    {
        foreach (Card card in _cards)
        {
            yield return card;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}