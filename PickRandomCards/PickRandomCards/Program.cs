namespace PickRandomCards;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wpisz liczbę generowanych kart: ");
        var line = Console.ReadLine();
        if (int.TryParse(line, out var numberOfCards))
        {
            foreach (var card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("Wpisz prawidłową liczbę.");
        }
    }
}