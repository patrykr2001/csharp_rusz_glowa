using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        using var ms = new MemoryStream();
        using (var sw = new StreamWriter(ms))
        {
            sw.WriteLine("Wartość wynosi {0:0.00}.", 123.45678);
            sw.Flush();
            Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
        }
    }
}
