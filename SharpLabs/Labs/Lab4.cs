namespace Labs;

public class Lab4 : ILab
{
    public string Name => "Множественный выбор";
    public int Number => 4;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Console.WriteLine("Элементы правильного треугольника:");
        Console.WriteLine("1. Сторона");
        Console.WriteLine("2. Периметр");
        Console.WriteLine("3. Площадь");
        Console.WriteLine();
        var n = Utils.Read<int>("Введите номер элемента", v => v is > 0 and < 4);
        var val = Utils.Read<double>("Введите значение");
        switch (n)
        {
            case 1:
                Utils.WriteLineCenter($"Сторона = {val}");
                Utils.WriteLineCenter($"Периметр = {val * 3}");
                Utils.WriteLineCenter($"Площадь = {Math.Sqrt(3) / 4 * Math.Pow(val, 2):.2}");
                return;
            
            case 2:
                Utils.WriteLineCenter($"Сторона = {val / 3}");
                Utils.WriteLineCenter($"Периметр = {val}");
                Utils.WriteLineCenter($"Площадь = {Math.Sqrt(3) / 4 * Math.Pow(val / 3, 2):.2}");
                return;
            
            case 3:
                var side = Math.Sqrt(4 * val / Math.Sqrt(3));
                Utils.WriteLineCenter($"Сторона = {side}");
                Utils.WriteLineCenter($"Периметр = {side * 3}");
                Utils.WriteLineCenter($"Площадь = {val:.2}");
                return;
        }
    }
}