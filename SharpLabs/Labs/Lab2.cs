namespace Labs;

public class Lab2 : ILab
{
    public string Name => "Операторы ввода-вывода, математические функции";
    public int Number => 2;
    
    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        var a = Utils.Read<double>("Введите диагональ a");
        var b = Utils.Read<double>("Введите диагональ b");
        var square = a * b / 2;
        Utils.WriteLineCenter($"Площадь ромба: {square:0.00}");
    }

    private static void Task2()
    {
        var x = Utils.Read<double>("Введите X");
        var numerator = Math.Sin(Math.Sqrt(Math.Pow(Math.Abs(1 - x), 3))) + Math.Pow(Math.E, 2 - x);
        var denumerator = Math.Log(2 + Math.Pow(x, 3), 3) + Math.Tan(1 / x - 1);
        var y = numerator / denumerator * (2 - x);
        Utils.WriteLineCenter($"Y равен: {y:0.00}");
    }
}