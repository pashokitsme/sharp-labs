namespace Labs.Day12;

public class Lab1 : ILab
{
    public string Name =>
        "Дан текстовый файл (файл text.txt должен содержать английский текст). Напечатать все нечетные строки";

    public int Number => 1;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Дан текстовый файл (файл text.txt должен содержать английский текст). Напечатать все нечетные строки.\n");

        const string path = "./text.txt";

        if (!File.Exists(path))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Utils.WriteLineCenter($"Файл {path} не найден");
            return;
        }

        var lines = File.ReadAllLines(path);
        for (var i = 0; i < lines.Length; i += 2)
            Utils.WriteLineCenter(lines[i]);
    }
}