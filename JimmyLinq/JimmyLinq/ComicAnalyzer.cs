namespace JimmyLinq;

static class ComicAnalyzer
{
    private static PriceRange CalculatePriceRange(Comic comic)
    {
        return Comic.Prices[comic.Issue] >= 100 ? PriceRange.Drogie : PriceRange.Tanie;
    }

    public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(IEnumerable<Comic> comics, Dictionary<int, decimal> prices)
    {
        return
            from comic in comics
            orderby prices[comic.Issue]
            group comic by CalculatePriceRange(comic) into priceGroup
            select priceGroup;
    }

    public static IEnumerable<string> GetReviews(IEnumerable<Comic> comics, IEnumerable<Review> reviews)
    {
        return
            from comic in comics
            orderby comic.Issue
            join review in reviews on comic.Issue equals review.Issue
            select $"{review.Critic} ocenił nr {comic.Issue} '{comic.Name}' na {review.Score:0.00}";
    }
}