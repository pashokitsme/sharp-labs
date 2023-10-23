namespace Labs;

public class Lab3 : ILab
{
    public string Name => "Условные конструкции";
    public int Number => 3;
    
    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        var f = (double x) => Math.Pow(x, 2); 
        var x = Utils.Read<double>("Введите x");
        var y = Utils.Read<double>("Введите y");
        var message = y is >= 0 and <= 1 && y >= f(x) ? $"Точка ({x}, {y}) принадлежит области" : $"Точка ({x}, {y}) не принадлежит области";
        Utils.WriteLineCenter(message);
    }

    private static void Task2()
    {
        var val = Utils.Read<int>("Введите число");
        while (val < 1000)
            val = Utils.Read<int>("Это число не четырёхзначное. Введите число");

        var message = val % 100 == val / 100 ? "Первые 2 цифры равны последним двум" : "Первые две цифры не равны последним двум";
        Utils.WriteLineCenter(message);
    }
}