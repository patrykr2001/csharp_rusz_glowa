namespace JimmyLinq;

public class Comic
{
    public static readonly IEnumerable<Review> Reviews = new[]
    {
        new Review() { Issue = 36, Critic = Critics.MuddyCritic, Score = 37.6 },
        new Review() { Issue = 74, Critic = Critics.RottenTornadoes, Score = 22.8 },
        new Review() { Issue = 74, Critic = Critics.MuddyCritic, Score = 84.2 },
        new Review() { Issue = 83, Critic = Critics.RottenTornadoes, Score = 89.4 },
        new Review() { Issue = 97, Critic = Critics.MuddyCritic, Score = 98.1 },
    };
    public string Name { get; set; }
    public int Issue { get; set; }
    
    public override string ToString() => $"{Name} (Numer {Issue})";

    public static readonly IEnumerable<Comic> Catalog = new[]
    {
        new Comic() { Name = "Johny America vs. The Pinko", Issue = 6 },
        new Comic() { Name = "Rock and Roll (edycja limitowana)", Issue = 19 },
        new Comic() { Name = "Woman's Work", Issue = 36 },
        new Comic() { Name = "Hippie Madness (z błędami w druku)", Issue = 57 },
        new Comic() { Name = "Revenge of the New Wave Freak (uszkodzony)", Issue = 68 },
        new Comic() { Name = "Black Monday", Issue = 74 },
        new Comic() { Name = "Tribal Tattoo Madness", Issue = 83 },
        new Comic() { Name = "Thhe Death of the Object ", Issue = 97 },
    };

    public static readonly Dictionary<int, decimal> Prices = new Dictionary<int, decimal>()
    {
        { 6, 3600m },
        { 19, 500m },
        { 36, 650m },
        { 57, 13525m },
        { 68, 250m },
        { 74, 75m },
        { 83, 25.75m },
        { 97, 35.25m },
    };
}