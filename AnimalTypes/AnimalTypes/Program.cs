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
            if (animal is Hippo hippo)
            {
                hippo.Swim();
            }

            if (animal is Wolf wolf)
            {
                wolf.HuntInPack();
            }
            
            Console.WriteLine();
        }
    }
}