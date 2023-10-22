internal static class Utils
{
    public static void WriteBufferCenter(IEnumerable<string> output)
    {
        Console.Clear();
        var count = output.Count();
        Console.SetCursorPosition(Console.CursorLeft, Console.BufferHeight / 2 - count / 2);
        foreach (var line in output)
            WriteLineCenter(line, top: Console.BufferHeight / 2 - count--);
        Console.ReadKey();
    }

    public static void WriteLineCenter(string output, bool newLine = true, int top = int.MaxValue)
    {
        if (top > Console.BufferHeight) top = Console.CursorTop;
        Console.SetCursorPosition(Math.Clamp(Console.BufferWidth / 2 - output.Length / 2, 0, Console.BufferWidth), top < Console.BufferHeight ? Math.Clamp(top, 0, Console.BufferHeight) : Console.CursorTop);
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

    public static T Read<T>(string welcome, Func<T, bool>? guard = null)
    where T : IParsable<T>
    {
        T val;
        do
        {
            Console.Write(welcome + " > ");
        } while (!(T.TryParse(Console.ReadLine(), default, out val) && (guard?.Invoke(val) ?? true)));

        return val;
    }

    public static string? Read(string welcome)
    {
        Console.Write(welcome + " > ");
        return Console.ReadLine();
    }
}