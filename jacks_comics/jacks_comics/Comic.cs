namespace jacks_comics;

public class Comic
{
    public string Name { get; set; }
    public int Issue { get; set; }
    
    public override string ToString() => $"{Name} (Numer {Issue})";
}