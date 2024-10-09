using JimmyLinq;

namespace JimmyLinqUnitTests;

[TestClass]
public class ComicAnalyzerTests
{
    private readonly IEnumerable<Comic> _testComics = new[]
    {
        new Comic() { Issue = 1, Name = "Numer 1"},
        new Comic() { Issue = 2, Name = "Numer 2"},
        new Comic() { Issue = 3, Name = "Numer 3"},
    };

    [TestMethod]
    public void ComicAnalyzer_Should_Group_Comics()
    {
        var prices = new Dictionary<int, decimal>()
        {
            { 1, 20m },
            { 2, 10m },
            { 3, 1000m },
        };
        
        var groups = ComicAnalyzer.GroupComicsByPrice(_testComics, prices);
        
        Assert.AreEqual(2, groups.Count());
        Assert.AreEqual(PriceRange.Tanie, groups.First().Key);
        Assert.AreEqual(2, groups.First().First().Issue);
        Assert.AreEqual("Numer 2", groups.First().First().Name);
    }

    [TestMethod]
    public void ComicAnalyzer_Should_Generate_A_List_Of_Reviews()
    {
        var testReviews = new[]
        {
            new Review() { Issue = 1, Critic = Critics.MuddyCritic, Score = 14.5 },
            new Review() { Issue = 1, Critic = Critics.RottenTornadoes, Score = 59.93 },
            new Review() { Issue = 2, Critic = Critics.MuddyCritic, Score = 40.3 },
            new Review() { Issue = 2, Critic = Critics.RottenTornadoes, Score = 95.11 },
        };

        var expectedResults = new[]
        {
            "MuddyCritic ocenił nr 1 'Numer 1' na 14,50",
            "RottenTornadoes ocenił nr 1 'Numer 1' na 59,93",
            "MuddyCritic ocenił nr 2 'Numer 2' na 40,30",
            "RottenTornadoes ocenił nr 2 'Numer 2' na 95,11",
        };
        
        var actualResults = ComicAnalyzer.GetReviews(_testComics, testReviews).ToList();
        CollectionAssert.AreEqual(expectedResults, actualResults);
    }
}