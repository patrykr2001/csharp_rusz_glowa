namespace AnimalTypes;

abstract class Animal
{
    public abstract void MakeNoise();
}

class Hippo : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("Chrząkanie.");
    }

    public void Swim()
    {
        Console.WriteLine("Plusk! Idę popływać!");
    }
}

abstract class Canine : Animal
{
    public bool BelongsToPack { get; protected set; } = false;
}

class Wolf : Canine
{
    public Wolf(bool belongsToPack)
    {
        BelongsToPack = belongsToPack;
    }
    
    public override void MakeNoise()
    {
        if(BelongsToPack)
            Console.WriteLine("Należę do stada!");
        Console.WriteLine("Auuuuuuuu!");
    }

    public void HuntInPack()
    {
        if (BelongsToPack)
        {
            Console.WriteLine("Wybieram się na polowanie ze stadem!");
        }
        else
        {
            Console.WriteLine("Nie należę do stada.");
        }
    }
}