namespace Labs.General;

public class Lab5 : ILab
{
    public string Name => "Циклы, подпрограммы";
    public int Number => 5;
    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        const int b = 10;
        var n = Utils.Read<int>("Введите N");
        Utils.WriteLineCenter("Площадь ромба");
        for (var i = 1; i <= n; i++)
            Utils.WriteLineCenter($"a: {i}\tb: {b}\ts: {i * b / 2:0.00}");
    }

    private static void Task2()
    {
        var sum = 0;
        while (true)
        {
            var val = Utils.Read<int>("Введите число, кратное 3", v => v % 3 == 0 || v < 0);
            if (val < 0) break;
            sum += val;
        }
        
        Utils.WriteLineCenter($"Сумма введёных чисел, кратных 3: {sum}");
    }
}