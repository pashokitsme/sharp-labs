namespace Labs;

public class Lab2 : ILab
{
    public string Name => "Операторы ввода-вывода, математические функции";
    public int Number => 2;
    
    public void Entry()
    {
        Task1();
        Task2();
    }

    private static void Task1()
    {
        var side = Utils.ReadDouble("Введите диагональ ромба");
        var square = Math.Pow(side, 2) / 2;
        Utils.WriteLineCenter($"Площадь ромба: {square:.2}");
    }

    private static void Task2()
    {
        var x = Utils.ReadDouble("Введите X");
        var numerator = Math.Sin(Math.Sqrt(Math.Pow(Math.Abs(1 - x), 3))) + Math.Pow(Math.E, 2 - x);
        var denumerator = Math.Log(2 + Math.Pow(x, 3), 3) + Math.Tan(1 / x - 1);
        var y = numerator / denumerator;
        Utils.WriteLineCenter($"Y равен: {y:.2}");
    }
}