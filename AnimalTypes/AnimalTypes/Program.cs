namespace AnimalTypes;

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals =
        [
            new Wolf(false),
            new Hippo(),
            new Wolf(true),
            new Wolf(false),
            new Hippo()
        ];

        foreach (var animal in animals)
        {
            animal.MakeNoise();
            if (animal is ISwimmer swimmer)
            {
                swimmer.Swim();
            }

            if (animal is IPackHunter packHunter)
            {
                packHunter.HuntInPack();
            }
            
            Console.WriteLine();
        }
    }
}