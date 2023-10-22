namespace Labs;

public class Lab5 : ILab
{
    public string Name => "Циклы, подпрограммы";
    public int Number => 5;
    public Action[] Entry() => new[] { Task1, Task2 };

    private static void Task1()
    {
        var a = Utils.Read<double>("Введите диагональ a");
        var b = Utils.Read<double>("Введите диагональ b");
        var square = a * b / 2;
        Utils.WriteLineCenter($"Площадь ромба: {square:.2}");
    }

    private static void Task2()
    {
        var sum = 0;
        while (true)
        {
            var val = Utils.Read<int>("Введите число, кратное 3", v => v % 3 == 0);
            if (val < 0) break;
            sum += val;
        }
        
        Utils.WriteLineCenter($"Сумма введёных чисел, кратных 3: {sum}");
    }
}