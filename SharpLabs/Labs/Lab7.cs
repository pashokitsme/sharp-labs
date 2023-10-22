using System.Text;

namespace Labs;

public class Lab7 : ILab
{
    public string Name => "Строки и множества";
    public int Number => 7;

    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        var values = new Dictionary<char, string>
        {
            { '0', "ноль" },
            { '1', "один" },
            { '2', "два" },
            { '3', "три" },
            { '4', "четыре" },
            { '5', "пять" },
            { '6', "шесть" },
            { '7', "семь" },
            { '8', "восемь" },
            { '9', "девять"}
        };

        var val = Utils.Read("Введите строку");
        var res = new StringBuilder();
        foreach (var part in val?.ToCharArray()!)
            res.Append(values.TryGetValue(part, out var n) ? n : part);
        
        Utils.WriteLineCenter($"Результат:");
        Utils.WriteLineCenter(res.ToString());
    }

    private static void Task2()
    {
        var val = Utils.Read("Введите строку 1") + Utils.Read("Введите строку 2");
        var numbers = val.ToCharArray().Where(char.IsNumber).Distinct().Select(x => x - '0').Order();
        var res = string.Join(", ", numbers);
        Utils.WriteLineCenter("Числа из двух строк, отсортированные:");
        Utils.WriteLineCenter(res);
    }
}