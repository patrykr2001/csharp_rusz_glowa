namespace linq_test;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i <= 99; i++)
        {
            numbers.Add(i);
        }
        IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5));
        foreach(var i in firstAndLastFive)
            Console.Write($"{i} ");
    }
}