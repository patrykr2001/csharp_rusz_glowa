namespace ElephantProgram;

class Program
{
    static void Main(string[] args)
    {
        Elephant laura = new Elephant() { Name = "Laura", EarSize = 80 };
        Elephant lucek = new Elephant() { Name = "Lucek", EarSize = 100 };

        while (true)
        {
            var input = ReadInt("Wciśnij 1 (Lucek), 2 (Laura) lub 3 (przestawienie), lub 0 aby wyjść:");

            switch (input)
            {
                case -1:
                    Console.WriteLine("Wpisz poprawną wartość!");
                    break;
                case 0:
                    return;
                case 1:
                    Console.WriteLine("Wcisnąłeś 1.");
                    Console.WriteLine("Wywołanie lucek.WhoAmI.");
                    lucek.WhoAmI();
                    break;
                case 2:
                    Console.WriteLine("Wcisnąłeś 2.");
                    Console.WriteLine("Wywołanie laura.WhoAmI.");
                    laura.WhoAmI();
                    break;
                case 3:
                    Console.WriteLine("Wcisnąłeś 3.");
                    Console.WriteLine("Referencje zostały przestawione.");
                    (laura, lucek) = (lucek, laura);
                    break;
            }
        }
    }
    
    /// <summary>
    /// Wyświetla informację i wczytuje wartość typu int z konsoli.
    /// </summary>
    /// <param name="prompt">Informacja wyświetlana w konsoli.</param>
    /// <returns>Wczytana wartość int lub wartość domyślna
    /// (jeśli nie można przetworzyć wczytanej wartości)</returns>
    private static int ReadInt(string prompt)
    {
        Console.WriteLine(prompt);
        var readValue = Console.ReadLine();
        if (int.TryParse(readValue, out int result))
        {
            return result;
        }
        else
        {
            return -1;
        }
    }
}