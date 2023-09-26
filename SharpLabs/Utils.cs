internal static class Utils
{
    public static void WriteBufferCenter(IEnumerable<string> output)
    {
        Console.Clear();
        var count = output.Count();
        Console.SetCursorPosition(Console.CursorLeft, Math.Clamp(Console.BufferHeight / 2 - count / 2, 0, Console.BufferHeight));
        foreach (var line in output)
            WriteLineCenter(line, top: Console.BufferHeight / 2 - count--);
        Console.ReadKey();
    }

    public static void WriteLineCenter(string output, bool newLine = true, int top = int.MaxValue)
    {
        if (top > Console.BufferHeight) top = Console.CursorTop;
        Console.SetCursorPosition(Math.Clamp(Console.BufferWidth / 2 - output.Length / 2, 0, Console.BufferWidth), top < Console.BufferHeight ? top : Console.CursorTop);
        if (newLine) Console.WriteLine(output);
        else Console.Write(output);
    }

    public static void WriteDottedLine(string lhs, string rhs, int pad = 10)
    {
        Console.SetCursorPosition(pad, Console.CursorTop);
        Console.Write(lhs);
        for (var i = 0; i < Console.BufferWidth - lhs.Length - rhs.Length - pad * 2; i++)
            Console.Write('.');
        Console.WriteLine(rhs);
    }
}