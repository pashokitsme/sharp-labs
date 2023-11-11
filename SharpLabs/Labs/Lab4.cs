namespace Labs;

public class Lab4 : ILab
{
    public string Name => "Операторы цикла";
    public int Number => 4;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("F(x) = sin^2(x) - cos(2x)");

        var a = Utils.Read<double>("Введите начало отрезка (a)");
        var b = Utils.Read<double>("Введите конец отрезка (b)");
        var h = Utils.Read<double>("Введите шаг");

        for (var i = a; i <= b; i += h)
            Utils.WriteLineCenter($"Для i = {i}, sin^2(x) - cos(2x) = {Math.Pow(Math.Sin(i), 2) - Math.Cos(2 * i)}");
    }
}