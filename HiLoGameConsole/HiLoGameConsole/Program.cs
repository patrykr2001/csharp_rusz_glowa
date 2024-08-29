namespace HiLoGameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w HiLo.");
            Console.WriteLine($"Odgadnij liczbę od 1 do {HiLoGame.MAXIMUM}");
            HiLoGame.Hint();
            while (HiLoGame.GetPot() > 0)
            {
                Console.WriteLine("Wciśnij w (większa), m (mniejsza) lub ? (kupno wskazówki).");
                Console.WriteLine($"Inne klawisze to koniec gry z {HiLoGame.GetPot()} zł.");
                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case 'w':
                        HiLoGame.Guess(true);
                        break;
                    case 'm':
                        HiLoGame.Guess(false);
                        break;
                    case '?':
                        HiLoGame.Hint();
                        break;
                    default:
                        return;
                }
            }
            Console.WriteLine("Skończyły Ci sie pieniądze. Do zobaczenia!");
        }
    }
}
