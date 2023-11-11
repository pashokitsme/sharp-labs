namespace Labs.Day10;

public class Lab2 : ILab
{
    public string Name => "Строки";
    public int Number => 2;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Определить сколько раз в строке встречается буквосочетание «ум»\n");

        const string pattern = "ум";
        var val = Utils.Read("Введите строку") ?? "";
        var count = 0;
        var index = 0;

        while ((index = val.IndexOf(pattern, index, StringComparison.Ordinal)) != -1)
        {
            count++;
            index += pattern.Length;
        }

        Utils.WriteLineCenter($"Количество буквосочетаний: {count}");
    }
}