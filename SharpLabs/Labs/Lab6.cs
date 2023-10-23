namespace Labs;

public class Lab6 : ILab
{
    public string Name => "Обработка исключений";
    public int Number => 6;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        var x = Utils.Read<double>("Введите X", x => x >= 0);
        var y = Math.Log2(x + 1) / (x - 1) - 1;
        Utils.WriteLineCenter($"Y равен: {y:0.00}");
    }
}