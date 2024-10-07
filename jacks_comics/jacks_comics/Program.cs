﻿namespace jacks_comics;

class Program
{
    static void Main(string[] args)
    {
        IEnumerable<Comic> mostExpensive =
            from comic in Comic.Catalog
            where Comic.Prices[comic.Issue] > 500
            orderby Comic.Prices[comic.Issue] descending
            select comic;

        foreach (var comic in mostExpensive)
        {
            Console.WriteLine($"{comic} jest wart {Comic.Prices[comic.Issue]:c}.");
        }
    }
}