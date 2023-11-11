using System.Text;

namespace Labs.Day9Task2;

public class Lab4 : ILab
{
    public string Name => "Вывести таблицу умножения";
    public int Number => 4;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Вывести таблицу умножения");

        const int n = 10;
        var sb = new StringBuilder();
        
        for (var a = 1; a <= n; a++)
            for (var b = 1; b <= n; b++)
                sb.AppendLine($"{a} * {b} = {a * b}");
        
        Console.WriteLine(sb);
    }
}