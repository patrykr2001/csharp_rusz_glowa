namespace MyFirstConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        OperatorExamples();
    }

    private static void OperatorExamples()
    {
        int width = 3;

        width++;

        int height = 2 + 4;
        int area = width * height;
        Console.WriteLine(area);
        
        while (area < 50)
        {
            height++;
            area = width * height;
        }

        do
        {
            width--;
            area = width * height;
        } while (area > 25);

        string result = "Powierzchnia";
        result = result + " wynosi " + area;
        Console.WriteLine(result);

        bool thruthValue = true;
        Console.WriteLine(thruthValue);
    }
}