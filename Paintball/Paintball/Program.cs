namespace Paintball;

class Program
{
    static void Main(string[] args)
    {
        int numberOfBalls = ReadInt(20, "Liczba kulek");
        int magazineSize = ReadInt(16, "Pojemność magazynka");
        Console.Write($"Załadowany [false]: ");
        bool.TryParse(Console.ReadLine(), out bool isLoaded);
        
        PaintballGun gun = new PaintballGun(numberOfBalls, magazineSize, isLoaded);
        
        while (true)
        {
            Console.WriteLine($"Kulki: {gun.Balls}, załadowano: {gun.BallsLoaded}");
            if (gun.IsEmpty()) Console.WriteLine("OSTRZEŻENIE: brak amunicji");
            Console.WriteLine("Spacja - strzał, p - przeładowanie, + - dodaj amunicję, k - koniec");
            
            char key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case ' ':
                    Console.WriteLine($"Próba strzału: {gun.Shoot()}");
                    break;
                case 'p':
                    gun.Reload();
                    break;
                case '+':
                    gun.Balls += gun.MagazineSize;
                    break;
                case 'k':
                    return;
            }
        }
    }
    
    private static int ReadInt(int defaultValue, string prompt)
    {
        Console.WriteLine(prompt);
        var readValue = Console.ReadLine();
        if (int.TryParse(readValue, out int result))
        {
            return result;
        }
        else
        {
            return defaultValue;
        }
    }
}