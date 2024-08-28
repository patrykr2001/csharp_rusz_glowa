namespace JazdaRandom;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomInt = random.Next();
        Console.WriteLine($"randomInt: {randomInt}");
        
        int zeroToNine = random.Next(10);
        Console.WriteLine($"zeroToNine: {zeroToNine}");
        
        int dieRoll = random.Next(1, 7);
        Console.WriteLine($"dieRoll : {dieRoll}");
        
        double randomDouble = random.NextDouble();
        Console.WriteLine($"randomDouble: {randomDouble * 100}");
        Console.WriteLine($"randomFloat: {(float)randomDouble * 100F}");
        Console.WriteLine($"randomDecimal: {(decimal)randomDouble * 100M}");
        
        int zerOrOne = random.Next(2);
        bool coinFlip = Convert.ToBoolean(zerOrOne);
        Console.WriteLine($"coinFlip: {coinFlip}");
    }
}