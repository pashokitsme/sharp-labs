namespace Labs.Day9Task2;

public class Lab6 : ILab
{
    public string Name => "Сумма введённых чисел";
    public int Number => 6;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        var sum = 0;
        while (true)
        {
            var val = Utils.Read<int>("Введите число. 0 для завершения ввода");
            if (val == 0) break;
            sum += val;
        }
        
        Utils.WriteLineCenter($"Сумма введёных чисел: {sum}");
    }
}