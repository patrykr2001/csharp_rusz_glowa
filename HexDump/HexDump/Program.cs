namespace HexDump;

class Program
{
    static void Main(string[] args)
    {
        var position = 0;
        using (var reader = new StreamReader("C:\\Users\\patry\\Learning\\C#\\csharp_rusz_glowa\\HexDump\\HexDump\\danetekstowe.txt"))
        {
            while (!reader.EndOfStream)
            {
                var buffer = new char[16];
                var bytesRead = reader.ReadBlock(buffer, 0, buffer.Length);
                if (bytesRead == 0)
                {
                    break;
                }

                Console.Write($"{position:X4}  ");
                position += bytesRead;

                for (var i = 0; i < 16; i++)
                {
                    if (i < bytesRead)
                    {
                        Console.Write($"{(byte)buffer[i]:X2} ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    if (i == 7)
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write(" ");
                for (var i = 0; i < bytesRead; i++)
                {
                    var ch = (char)buffer[i];
                    if (char.IsWhiteSpace(ch) || char.IsControl(ch))
                    {
                        ch = '.';
                    }

                    Console.Write(ch);
                }

                Console.WriteLine();
            }
        }
    }
}