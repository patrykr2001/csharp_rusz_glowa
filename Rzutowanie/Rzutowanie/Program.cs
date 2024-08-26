namespace Rzutowanie;

class Program
{
    static void Main(string[] args)
    {
        /*float myFloatValue = 10;
        int myIntValue = (int) myFloatValue;
        Console.WriteLine("myIntValue równa się " + myIntValue);*/

        /*int myInt = 36;
        float myFloat = 16.4F;
        myFloat = myInt + myFloat;*/

        /*int myInt = 10;
        byte myByte = (byte)myInt;
        double myDouble = (double)myByte;
        bool myBool = (bool)myDouble;
        string myString = "false";
        myBool = (bool)myString;
        myString = (string)myInt;
        myString = myInt.ToString();
        myBool = (bool)myByte;
        myByte = (byte)myBool;
        short myShort = (short)myInt;
        char myChar = 'x';
        myString = (string)myChar;
        long myLong = (long)myInt;
        decimal myDecimal = (decimal)myLong;
        myString = myString + myInt + myByte + myDouble + myChar;*/

        AbilityScoreCalculator calculator = new AbilityScoreCalculator();
        while (true)
        {
            calculator.RollResult = ReadInt(calculator.RollResult, "Początkowy rzut 3d6");
            calculator.DivideBy = ReadDouble(calculator.DivideBy, "Dzielone przez");
            calculator.AddAmount = ReadInt(calculator.AddAmount, "Dodawana wartość");
            calculator.CalculateAbilityScore();
            Console.WriteLine("Obliczone punkty umiejętności: " + calculator.Score);
            Console.WriteLine("Wciśnij Q, aby zakończyć, lub inny klawisz, aby kontynuować");
            char keyChar = Console.ReadKey(true).KeyChar;
            if ((keyChar == 'Q') || (keyChar == 'q')) return;
        }
    }
    
    /// <summary>
    /// Wyświetla informację i wczytuje wartość typu double z konsoli.
    /// </summary>
    /// <param name="lastUsedValue">Wartość domyślna.</param>
    /// <param name="prompt">Informacja wyświetlana w konsoli.</param>
    /// <returns>Wczytana wartość double lub wartość domyślna
    /// (jeśli nie można przetworzyć wczytanej wartości)</returns>
    private static double ReadDouble(double lastUsedValue, string prompt)
    {
        Console.WriteLine(prompt);
        var readValue = Console.ReadLine();
        if (double.TryParse(readValue, out double result))
        {
            Console.WriteLine(" użycie wartości " + result);
            return result;
        }
        else
        {
            Console.WriteLine(" używanie wartości domyślnej " + lastUsedValue);
            return lastUsedValue;
        }
    }

    /// <summary>
    /// Wyświetla informację i wczytuje wartość typu int z konsoli.
    /// </summary>
    /// <param name="lastUsedValue">Wartość domyślna.</param>
    /// <param name="prompt">Informacja wyświetlana w konsoli.</param>
    /// <returns>Wczytana wartość int lub wartość domyślna
    /// (jeśli nie można przetworzyć wczytanej wartości)</returns>
    private static int ReadInt(int lastUsedValue, string prompt)
    {
        Console.WriteLine(prompt);
        var readValue = Console.ReadLine();
        if (int.TryParse(readValue, out int result))
        {
            Console.WriteLine(" użycie wartości " + result);
            return result;
        }
        else
        {
            Console.WriteLine(" używanie wartości domyślnej " + lastUsedValue);
            return lastUsedValue;
        }
    }
}