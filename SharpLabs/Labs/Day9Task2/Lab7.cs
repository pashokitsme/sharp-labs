namespace Labs.Day9Task2;

public class Lab7 : ILab
{
    public string Name => "Сумма введённых чётных чисел";
    public int Number => 7;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        var sum = 0;
        while (true)
        {
            var val = Utils.Read<int>("Введите чётное число. 0 для завершения ввода", v => v % 2 == 0);
            if (val == 0) break;
            sum += val;
        }
        
        Utils.WriteLineCenter($"Сумма введёных чисел: {sum}");
    }
}