﻿namespace ObliczanieObrazekConsole;

class Program
{
    private static readonly Random Random = new();
    static void Main(string[] args)
    {
        SwordDamage swordDamage = new(RollDice(3));
        ArrowDamage arrowDamage = new(RollDice(1));
        
        while (true)
        {
            Console.WriteLine("0 - ani magiczny, ani płonący, 1 - magiczny, 2 - płonący, 3 - magiczny i płonący," +
                              " inne klawisze - koniec");
            
            char key = Console.ReadKey().KeyChar;
            if (key != '0' && key != '1' && key != '2' && key != '3') return;
            
            Console.Write("\nM - miecz, S - strzały, inne znaki - koniec!");
            var weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

            switch (weaponKey)
            {
                case 'M':
                    swordDamage.Roll = RollDice(3);
                    swordDamage.Magic = key is '1' or '3';
                    swordDamage.Flaming = key is '2' or '3';
                    Console.WriteLine($"\nRzut {swordDamage.Roll}, punkty obrażeń {swordDamage.Damage} \n");
                    break;
                case 'S':
                    arrowDamage.Roll = RollDice(1);
                    arrowDamage.Magic = key is '1' or '3';
                    arrowDamage.Flaming = key is '2' or '3';
                    Console.WriteLine($"\nRzut: {arrowDamage.Roll}, punkty obrażeń {arrowDamage.Damage} \n");
                    break;
                default:
                    return;
            }
        }
    }

    private static int RollDice(int numberOfRolls)
    {
        int total = 0;
        for (int i = 0; i < numberOfRolls; i++) total += Random.Next(1, 7);
        return total;
    }
}