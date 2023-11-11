namespace Labs;

public class Lab1 : ILab
{
    public string Name => "Операторы ввода-вывода";

    public int Number => 1;
    
    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        Utils.WriteLineCenter("(3 + e^y-1) / (1 + x^2 * |y-tgx|)");
        
        var x = Utils.Read<double>("Введите x");
        var y = Utils.Read<double>("Введите y");
        var ans = (3 + Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));
        Utils.WriteLineCenter($"Ответ: {ans:0.00}");
    }

    private static void Task2()
    {
        Utils.WriteLineCenter("Даны два числа. Найти среднее арифметическое кубов и среднее геометрическое модулей этих чисел.");
        
        var a = Utils.Read<double>("Введите число 1");
        var b = Utils.Read<double>("Введите число 2");
        
        Utils.WriteLineCenter($"Среднее арифметическое кубов чисел: {(Math.Pow(a, 3) + Math.Pow(b, 3)) / 2}");
        Utils.WriteLineCenter($"Среднее геометрическое модулей чисел: {Math.Sqrt(Math.Abs(a) * Math.Abs(b))}");
    }
}