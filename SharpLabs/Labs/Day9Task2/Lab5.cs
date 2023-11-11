namespace Labs.Day9Task2;

public class Lab5 : ILab
{
    public string Name => "Количество целых a-b, которые делятся на 12";
    public int Number => 5;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Найдите количество целых чисел от a до b, которые делятся на 12");

        var a = Utils.Read<int>("Введите a");
        var b = Utils.Read<int>("Введите b");

        var n = Enumerable.Range(a, a - b + 1).Where(v => v % 12 == 0);
        Utils.WriteLineCenter($"Количество чисел от {a} до {b}, которые делятся на 12: ${n.Count()}");
    }
}