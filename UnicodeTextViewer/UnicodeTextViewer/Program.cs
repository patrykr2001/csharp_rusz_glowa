using System.Text;

namespace UnicodeTextViewer;

class Program
{
    static void Main(string[] args)
    {
        File.WriteAllText("eureka.txt", "Eureka! 🎉", Encoding.Unicode);
        byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
        foreach (var b in eurekaBytes)
        {
            Console.Write("{0:x2} ", b);
        }
        Console.WriteLine();
        Console.WriteLine("Liczba bajtów: {0}", eurekaBytes.Length);
    }
}