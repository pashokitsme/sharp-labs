namespace Labs.Day11;

public class Lab1 : ILab
{
    public string Name => "Методы";
    public int Number => 1;

    public Action[] Tasks() => new[] { Task1, Task2, Task3 };

    #region Task1
    
    private static void Task1()
    {
        Utils.WriteLineCenter("Составить функцию нахождения площади ромба по его диагоналям. С помощью данной  функции вычислить площади для N ромбов.\n");

        var n = Utils.Read<int>("Введите количество ромбов");
        for (var i = 0; i < n; i++)
            CalculateRhombusArea();
    }

    private static void CalculateRhombusArea()
    {
        var a = Utils.Read<double>("Введите диагональ a");
        var b = Utils.Read<double>("Введите диагональ b");

        Utils.WriteLineCenter($"Площадь ромба ({a}x{b}): {a * b / 2}\n");
    }
    
    #endregion

    #region Task2

    private static void Task2()
    {
        Utils.WriteLineCenter("С помощью метода вычислить (tg(x) + ctg(y)) / (ctg(x) + tg(y))\n");

        var x = Utils.Read<double>("Введите x");
        var y = Utils.Read<double>("Введите y");
        
        Utils.WriteLineCenter($"Результат: {CalculateFormula(x, y)}");
    }

    private static double CalculateFormula(double x, double y) 
        => (Math.Tan(x) + 1 / Math.Tan(y)) / (1 / Math.Tan(x) + Math.Tan(y));

    #endregion

    #region Task3

    private static void Task3()
    {
        Utils.WriteLineCenter("Описать рекурсивную функцию вычисления дроби");

        var n = Utils.Read<int>("Введите n");
        Utils.WriteLineCenter($"Результат: {CalculateRecursive(n)}");
    }

    private static double CalculateRecursive(int x, int n = 0) 
        => n > x ? 1 : 1 / CalculateRecursive(x, ++n);

    #endregion
}